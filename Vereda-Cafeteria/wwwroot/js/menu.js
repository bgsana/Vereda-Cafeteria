// =============================================
// VEREDA CAFETERIA — Menu JS
// Responsável: modal de produto + carrinho (localStorage)
// =============================================

const CHAVE_CARRINHO = 'vereda_carrinho';

// --- Carrinho helpers ---

function obterCarrinho() {
    const dados = localStorage.getItem(CHAVE_CARRINHO);
    return dados ? JSON.parse(dados) : [];
}

function salvarCarrinho(carrinho) {
    localStorage.setItem(CHAVE_CARRINHO, JSON.stringify(carrinho));
}

function totalItens(carrinho) {
    return carrinho.reduce((soma, item) => soma + item.quantidade, 0);
}

function atualizarBadge() {
    const badge = document.getElementById('badge-carrinho');
    if (!badge) return;
    badge.textContent = totalItens(obterCarrinho());
}

// --- Scroll lock sem layout shift ---
// Calcula a largura da scrollbar antes de bloquear o scroll,
// compensando com padding para evitar deslocamento de conteúdo.

function bloquearScroll() {
    const larguraScrollbar = window.innerWidth - document.documentElement.clientWidth;
    document.documentElement.style.setProperty('--scrollbar-width', larguraScrollbar + 'px');
    document.body.classList.add('modal-aberto');
}

function liberarScroll() {
    document.body.classList.remove('modal-aberto');
    document.documentElement.style.removeProperty('--scrollbar-width');
}

// --- Modal ---

let produtoAtual = null;

function abrirModal(card) {
    produtoAtual = {
        id: parseInt(card.dataset.id),
        nome: card.dataset.nome,
        descricao: card.dataset.descricao,
        preco: parseFloat(card.dataset.preco),
        imagem: card.dataset.imagem,
        cor: card.dataset.cor
    };

    document.getElementById('modal-nome').textContent = produtoAtual.nome;
    document.getElementById('modal-descricao').textContent = produtoAtual.descricao;
    document.getElementById('modal-preco').textContent = 'R$ ' + produtoAtual.preco.toFixed(2).replace('.', ',');
    document.getElementById('modal-imagem').src = produtoAtual.imagem;
    document.getElementById('modal-imagem').alt = produtoAtual.nome;
    document.getElementById('modal-quantidade').textContent = '1';

    // Aplica a cor da categoria nos botões do modal via CSS custom property
    const modal = document.querySelector('.modal-produto');
    modal.style.setProperty('--cor-modal', produtoAtual.cor);

    document.getElementById('modal-overlay').classList.add('ativo');
    bloquearScroll();
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
}

// --- Adicionar ao carrinho ---

function adicionarAoCarrinho() {
    if (!produtoAtual) return;

    const quantidade = parseInt(document.getElementById('modal-quantidade').textContent);
    const carrinho = obterCarrinho();

    const indexExistente = carrinho.findIndex(item => item.id === produtoAtual.id);

    if (indexExistente >= 0) {
        carrinho[indexExistente].quantidade += quantidade;
    } else {
        carrinho.push({
            id: produtoAtual.id,
            nome: produtoAtual.nome,
            preco: produtoAtual.preco,
            imagem: produtoAtual.imagem,
            quantidade: quantidade
        });
    }

    salvarCarrinho(carrinho);
    atualizarBadge();
    fecharModal();
}

// --- Fechar com Esc ---

document.addEventListener('keydown', function (e) {
    if (e.key === 'Escape') fecharModal();
});

// --- Init ---

document.addEventListener('DOMContentLoaded', function () {
    atualizarBadge();
});