// =============================================
// VEREDA CAFETERIA — Carrinho JS
// Responsável: renderização e gestão do carrinho
// =============================================

const CHAVE_CARRINHO = "vereda_carrinho";
const CHAVE_TIMESTAMP = "vereda_carrinho_ts";
const EXPIRACAO_MS = 4 * 60 * 60 * 1000; // 4 horas

// --- Helpers de localStorage ---

function obterCarrinho() {
  const ts = localStorage.getItem(CHAVE_TIMESTAMP);
  if (ts && Date.now() - parseInt(ts) > EXPIRACAO_MS) {
    localStorage.removeItem(CHAVE_CARRINHO);
    localStorage.removeItem(CHAVE_TIMESTAMP);
    return [];
  }
  const dados = localStorage.getItem(CHAVE_CARRINHO);
  return dados ? JSON.parse(dados) : [];
}

function salvarCarrinho(carrinho) {
  localStorage.setItem(CHAVE_CARRINHO, JSON.stringify(carrinho));
  if (!localStorage.getItem(CHAVE_TIMESTAMP)) {
    localStorage.setItem(CHAVE_TIMESTAMP, Date.now().toString());
  }
}

function formatarPreco(valor) {
  return "R$ " + valor.toFixed(2).replace(".", ",");
}

// --- Renderização principal ---

function renderizar() {
  const carrinho = obterCarrinho();
  renderizarItens(carrinho);
  renderizarResumo(carrinho);
}

function renderizarItens(carrinho) {
  const coluna = document.getElementById("coluna-itens");

  if (carrinho.length === 0) {
    coluna.innerHTML = `
            <div class="carrinho-vazio">
                <i class="ti ti-shopping-cart-off"></i>
                <p>Seu carrinho está vazio.<br>Volte ao <a href="/Menu">Menu</a> ou à <a href="/Atelie">Vereda Ateliê</a> para adicionar itens.</p>
            </div>`;
    return;
  }

  coluna.innerHTML = carrinho
    .map((item, index) => {
      const cor = item.cor || "#730000";

      const escolhaHtml = item.opcao
        ? `<p style="color:${cor}">Escolha: ${item.opcao}</p>`
        : "";

      const editarHtml = item.opcao
        ? `<button class="btn-editar" style="color:${cor}" onclick="abrirEditar(${index})">
                   <i class="ti ti-edit"></i>
                   <span class="texto-editar">Editar</span>
               </button>`
        : "";

      return `
        <div class="item-carrinho" id="item-${index}" onclick="abrirDetalhe(${index})" style="cursor:pointer">
            <div class="coluna-esquerda">
                <div class="info-item">
                    <h2 style="color:${cor}">${item.nome}</h2>
                    ${escolhaHtml}
                    <h3 id="preco-${index}" style="color:${cor}">${formatarPreco(item.preco * item.quantidade)}</h3>
                    <div class="acoes" onclick="event.stopPropagation()">
                        <div class="btn-quantidade" style="background-color:${cor}">
                            <button class="btn-subtracao" onclick="alterarQuantidade(${index}, -1)">-</button>
                            <span id="qtd-${index}">${item.quantidade}</span>
                            <button class="btn-adicao" onclick="alterarQuantidade(${index}, 1)">+</button>
                        </div>
                        ${editarHtml}
                        <button class="btn-excluir" onclick="excluirItem(${index})" style="color:${cor}">
                                <i class="ti ti-trash" style="color:${cor}"></i>
                                <span class="texto-excluir">Excluir</span>
                            </button>
                    </div>
                </div>
            </div>
            <div class="coluna-direita" style="background-color:${cor}">
                <img class="imagem-item" src="${item.imagem}" alt="${item.nome}">
            </div>
        </div>`;
    })
    .join("");
}

function renderizarResumo(carrinho) {
  const linhas = document.getElementById("resumo-linhas");
  const total = document.getElementById("resumo-total-valor");
  const btnFinal = document.getElementById("btn-finalizar");

  if (carrinho.length === 0) {
    linhas.innerHTML =
      '<span class="resumo-vazio">Nenhum item adicionado.</span>';
    total.textContent = "R$ 0,00";
    btnFinal.disabled = true;
    return;
  }

  btnFinal.disabled = false;

  linhas.innerHTML = carrinho
    .map(
      (item) =>
        `<span>${item.quantidade}x ${item.nome}${item.opcao ? ` (${item.opcao})` : ""}</span>`,
    )
    .join("");

  const valorTotal = carrinho.reduce(
    (soma, item) => soma + item.preco * item.quantidade,
    0,
  );
  total.textContent = formatarPreco(valorTotal);
}

// --- Ações dos cards ---

function alterarQuantidade(index, delta) {
  const carrinho = obterCarrinho();
  carrinho[index].quantidade += delta;
  if (carrinho[index].quantidade < 1) carrinho[index].quantidade = 1;
  salvarCarrinho(carrinho);

  const item = carrinho[index];
  document.getElementById(`qtd-${index}`).textContent = item.quantidade;
  document.getElementById(`preco-${index}`).textContent = formatarPreco(
    item.preco * item.quantidade,
  );
  renderizarResumo(carrinho);
}

function excluirItem(index) {
  const carrinho = obterCarrinho();
  carrinho.splice(index, 1);
  salvarCarrinho(carrinho);
  renderizar();
}

// --- Modal de edição de escolha ---

let indexEditando = null;

function abrirEditar(index) {
  const carrinho = obterCarrinho();
  const item = carrinho[index];
  const cor = item.cor || "#730000";

  indexEditando = index;

  document.getElementById("modal-editar-nome").textContent = item.nome;
  document.getElementById("modal-editar-nome").style.color = cor;
  document.getElementById("modal-editar-descricao").textContent =
    item.descricao || "";
  document.getElementById("modal-editar-descricao").style.color = cor;

  const btnConfirmar = document.getElementById("modal-editar-confirmar");
  btnConfirmar.style.backgroundColor = cor;

  document.querySelector(".modal-editar").style.setProperty("--cor-modal", cor);

  const secaoOpcoes = document.getElementById("modal-editar-opcoes");

  if (!item.todasOpcoes || item.todasOpcoes.length === 0) {
    // Item legado sem todasOpcoes salvo — orienta o usuário
    secaoOpcoes.innerHTML = `
            <p style="text-align:center;font-size:13px;opacity:0.6;color:${cor}">
                Opções não disponíveis.<br>Remova o item e adicione novamente pelo cardápio.
            </p>`;
  } else {
    let html = '<div class="modal-opcoes-grid">';
    item.todasOpcoes.forEach((opcao) => {
      const checked = opcao === item.opcao ? "checked" : "";
      html += `
                <label class="modal-opcao-label" style="color:${cor}">
                    <input type="radio"
                           name="opcao-editar"
                           value="${opcao}"
                           ${checked}
                           style="accent-color:${cor}">
                    <span>${opcao}</span>
                </label>`;
    });
    html += "</div>";
    secaoOpcoes.innerHTML = html;
  }

  document.getElementById("modal-editar-overlay").classList.add("ativo");
  bloquearScroll();
}

function confirmarEdicao() {
  if (indexEditando === null) return;

  const selecionado = document.querySelector(
    'input[name="opcao-editar"]:checked',
  );
  if (!selecionado) {
    fecharModalEditar();
    return;
  }

  const carrinho = obterCarrinho();
  const item = carrinho[indexEditando];
  const novaOpcao = selecionado.value;

  const novaChave = `${item.id}_${novaOpcao}`;
  const indexDuplicado = carrinho.findIndex(
    (i, idx) => i.chave === novaChave && idx !== indexEditando,
  );

  if (indexDuplicado >= 0) {
    // Se a nova opção já existe como item separado, soma as quantidades e remove o atual
    carrinho[indexDuplicado].quantidade += item.quantidade;
    carrinho.splice(indexEditando, 1);
  } else {
    carrinho[indexEditando].opcao = novaOpcao;
    carrinho[indexEditando].chave = novaChave;
  }

  salvarCarrinho(carrinho);
  fecharModalEditar();
  renderizar();
}

function fecharModalEditar() {
  document.getElementById("modal-editar-overlay").classList.remove("ativo");
  liberarScroll();
  indexEditando = null;
}

function fecharModalEditarOverlay(event) {
  if (event.target === document.getElementById("modal-editar-overlay")) {
    fecharModalEditar();
  }
}

// --- Modal de detalhe (somente leitura) ---

function abrirDetalhe(index) {
  const carrinho = obterCarrinho();
  const item = carrinho[index];
  const cor = item.cor || "#730000";

  document.getElementById("modal-imagem").src = item.imagem;
  document.getElementById("modal-imagem").alt = item.nome;
  document.getElementById("modal-nome").textContent = item.nome;
  document.getElementById("modal-nome").style.color = cor;
  document.getElementById("modal-descricao").textContent = item.descricao || "";
  document.getElementById("modal-descricao").style.color = cor;
  document.getElementById("modal-preco").textContent = formatarPreco(
    item.preco,
  );
  document.getElementById("modal-preco").style.color = cor;

  document.getElementById("modal-overlay").classList.add("ativo");
  bloquearScroll();
}

function fecharModal() {
  document.getElementById("modal-overlay").classList.remove("ativo");
  liberarScroll();
}

function fecharModalOverlay(event) {
  if (event.target === document.getElementById("modal-overlay")) {
    fecharModal();
  }
}

// --- Scroll lock ---

function bloquearScroll() {
  const largura = window.innerWidth - document.documentElement.clientWidth;
  document.documentElement.style.setProperty(
    "--scrollbar-width",
    largura + "px",
  );
  document.body.classList.add("modal-aberto");
}

function liberarScroll() {
  document.body.classList.remove("modal-aberto");
  document.documentElement.style.removeProperty("--scrollbar-width");
}

document.addEventListener("keydown", (e) => {
  if (e.key === "Escape") {
    fecharModal();
    fecharModalEditar();
  }
});

// --- Init ---
document.addEventListener("DOMContentLoaded", renderizar);
