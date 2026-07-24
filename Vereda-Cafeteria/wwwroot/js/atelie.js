const CHAVE_CARRINHO  = 'vereda_carrinho';
const CHAVE_TIMESTAMP = 'vereda_carrinho_ts';
const EXPIRACAO_MS    = 4 * 60 * 60 * 1000; // 4 horas

// --- Carrinho helpers ---

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

function totalItens(carrinho) {
    return carrinho.reduce((soma, item) => soma + item.quantidade, 0);
}

function atualizarBadge() {
    const badge = document.getElementById('badge-carrinho');
    if (!badge) return;
    badge.textContent = totalItens(obterCarrinho());
}

function bloquearScroll() {
    const larguraScrollbar = window.innerWidth - document.documentElement.clientWidth;
    document.documentElement.style.setProperty('--scrollbar-width', larguraScrollbar + 'px');
    document.body.classList.add('modal-aberto');
}

function liberarScroll() {
    document.body.classList.remove('modal-aberto');
    document.documentElement.style.removeProperty('--scrollbar-width');
}

let produtoAtual = null;

function abrirModal(card) {
    const opcoesBruto = card.dataset.opcoes;
    const opcoes = opcoesBruto ? JSON.parse(opcoesBruto) : [];

    produtoAtual = {
        id: parseInt(card.dataset.id),
        nome: card.dataset.nome,
        descricao: card.dataset.descricao,
        preco: parseFloat(card.dataset.preco),
        imagem: card.dataset.imagem,
        cor: card.dataset.cor,
        opcoes: opcoes,
        opcaoSelecionada: opcoes.length > 0 ? opcoes[0].nome : null
    };

    document.getElementById('modal-nome').textContent = produtoAtual.nome;
    document.getElementById('modal-descricao').textContent = produtoAtual.descricao;
    document.getElementById('modal-preco').textContent = 'R$ ' + produtoAtual.preco.toFixed(2).replace('.', ',');
    document.getElementById('modal-imagem').src = produtoAtual.imagem;
    document.getElementById('modal-imagem').alt = produtoAtual.nome;
    document.getElementById('modal-quantidade').textContent = '1';

    const modal = document.querySelector('.modal-produto');
    modal.style.setProperty('--cor-modal', produtoAtual.cor);

    const secaoOpcoes = document.getElementById('modal-secao-opcoes');
    if (opcoes.length > 0) {
        renderizarOpcoes(opcoes, produtoAtual.cor);
        secaoOpcoes.style.display = 'block';
    } else {
        secaoOpcoes.style.display = 'none';
        secaoOpcoes.innerHTML = '';
    }

    document.getElementById('modal-overlay').classList.add('ativo');
    bloquearScroll();
}

function renderizarOpcoes(opcoes, cor) {
    const secao = document.getElementById('modal-secao-opcoes');

    let html = '<div class="modal-opcoes-grid">';
    opcoes.forEach((opcao, index) => {
        const checked = index === 0 ? 'checked' : '';
        html += `
            <label class="modal-opcao-label">
                <input type="radio"
                       name="opcao-produto"
                       value="${opcao.nome}"
                       ${checked}
                       onchange="selecionarOpcao('${opcao.nome}')">
                <span>${opcao.nome}</span>
            </label>`;
    });
    html += '</div>';

    secao.innerHTML = html;
    secao.style.setProperty('--cor-modal', cor);
}

function selecionarOpcao(nome) {
    if (produtoAtual) {
        produtoAtual.opcaoSelecionada = nome;
    }
}

function fecharModal() {
    document.getElementById('modal-overlay').classList.remove('ativo');
    liberarScroll();
    produtoAtual = null;
}

function fecharModalOverlay(event) {
    if (event.target === document.getElementById('modal-overlay')) {
        fecharModal();
    }
}

function alterarQuantidade(delta) {
    const span = document.getElementById('modal-quantidade');
    let qtd = parseInt(span.textContent) + delta;
    if (qtd < 1) qtd = 1;
    span.textContent = qtd;

    if (produtoAtual) {
        const total = produtoAtual.preco * qtd;
        document.getElementById('modal-preco').textContent = 'R$ ' + total.toFixed(2).replace('.', ',');
    }
}

function adicionarAoCarrinho() {
    if (!produtoAtual) return;

    if (produtoAtual.opcoes.length > 0 && !produtoAtual.opcaoSelecionada) {
        alert('Por favor, selecione uma opção antes de adicionar ao carrinho.');
        return;
    }

    const quantidade = parseInt(document.getElementById('modal-quantidade').textContent);
    const carrinho = obterCarrinho();

    const chaveItem = produtoAtual.opcaoSelecionada
        ? `${produtoAtual.id}_${produtoAtual.opcaoSelecionada}`
        : `${produtoAtual.id}`;

    const indexExistente = carrinho.findIndex(item => item.chave === chaveItem);

    if (indexExistente >= 0) {
        carrinho[indexExistente].quantidade += quantidade;
    } else {
        carrinho.push({
            chave: chaveItem,
            id: produtoAtual.id,
            nome: produtoAtual.nome,
            descricao: produtoAtual.descricao,
            preco: produtoAtual.preco,
            imagem: produtoAtual.imagem,
            cor: produtoAtual.cor,
            quantidade: quantidade,
            opcao: produtoAtual.opcaoSelecionada || null,
            todasOpcoes: produtoAtual.opcoes.map(o => o.nome)
        });
    }

    salvarCarrinho(carrinho);
    atualizarBadge();
    fecharModal();
}

document.addEventListener('keydown', function (e) {
    if (e.key === 'Escape') fecharModal();
});

document.addEventListener('DOMContentLoaded', function () {
    atualizarBadge();
});
