// =============================================
// VEREDA CAFETERIA — Finalização do Pedido JS
// =============================================

const CHAVE_CARRINHO = 'vereda_carrinho';
const CHAVE_TIMESTAMP = 'vereda_carrinho_ts';
const EXPIRACAO_MS = 4 * 60 * 60 * 1000;
const TAXA_ENTREGA = 8;
const NUMERO_WHATSAPP = '5514991941596';

let modoEntrega = false;
let mensagemGerada = '';

// --- Carrinho ---

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

function limparCarrinho() {
    localStorage.removeItem(CHAVE_CARRINHO);
    localStorage.removeItem(CHAVE_TIMESTAMP);
}

function formatarPreco(valor) {
    return 'R$ ' + valor.toFixed(2).replace('.', ',');
}

// --- Resumo ---

function calcularSubtotal(carrinho) {
    return carrinho.reduce((soma, item) => soma + item.preco * item.quantidade, 0);
}

function renderizarResumo() {
    const carrinho = obterCarrinho();
    const linhas = document.getElementById('resumo-linhas');
    const valorTotal = document.getElementById('valor-total');

    if (carrinho.length === 0) {
        linhas.innerHTML = '<span style="opacity:0.6;font-size:13px">Nenhum item no carrinho.</span>';
        valorTotal.textContent = 'R$ 0,00';
        return;
    }

    linhas.innerHTML = carrinho
        .map(item => `<span>${item.quantidade}x ${item.nome}${item.opcao ? ` (${item.opcao})` : ''}</span>`)
        .join('');

    atualizarTotal();
}

function atualizarTotal() {
    const carrinho = obterCarrinho();
    const subtotal = calcularSubtotal(carrinho);
    const total = subtotal + (modoEntrega ? TAXA_ENTREGA : 0);
    document.getElementById('valor-total').textContent = formatarPreco(total);
}

// --- Forma de recebimento ---

function selecionarOpcao(opcao) {
    const btnRetirada = document.getElementById('btn-retirada');
    const btnEntrega = document.getElementById('btn-entrega');
    const camposEnd = document.getElementById('campos-endereco');
    const infoRet = document.getElementById('info-retirada');
    const linhaTaxa = document.getElementById('linha-taxa');

    modoEntrega = opcao === 'entrega';

    if (modoEntrega) {
        btnEntrega.classList.add('ativo');
        btnRetirada.classList.remove('ativo');
        camposEnd.classList.add('visivel');
        infoRet.classList.remove('visivel');
        linhaTaxa.style.display = 'flex';
    } else {
        btnRetirada.classList.add('ativo');
        btnEntrega.classList.remove('ativo');
        camposEnd.classList.remove('visivel');
        infoRet.classList.add('visivel');
        linhaTaxa.style.display = 'none';
    }

    atualizarTotal();
}

// --- Validação ---

function validar(carrinho) {
    const nome = document.getElementById('campo-nome').value.trim();
    const tel = document.getElementById('campo-telefone').value.trim();

    if (carrinho.length === 0) {
        alert('Seu carrinho está vazio. Adicione itens antes de confirmar.');
        return false;
    }
    if (!nome) {
        alert('Por favor, informe o seu nome.');
        document.getElementById('campo-nome').focus();
        return false;
    }
    if (!tel) {
        alert('Por favor, informe o seu telefone.');
        document.getElementById('campo-telefone').focus();
        return false;
    }

    if (modoEntrega) {
        const cidade = document.getElementById('campo-cidade').value;
        const rua = document.getElementById('campo-rua').value.trim();
        const numero = document.getElementById('campo-numero').value.trim();
        const bairro = document.getElementById('campo-bairro').value.trim();

        if (!cidade) { alert('Por favor, selecione a cidade.'); return false; }
        if (!rua) { alert('Por favor, informe a rua/avenida.'); return false; }
        if (!numero) { alert('Por favor, informe o número.'); return false; }
        if (!bairro) { alert('Por favor, informe o bairro.'); return false; }
    }

    return true;
}

// --- Montar mensagem ---

function montarMensagem(carrinho) {
    const nome      = document.getElementById('campo-nome').value.trim();
    const tel       = document.getElementById('campo-telefone').value.trim();
    const pagamento = document.querySelector('input[name="pagamento"]:checked').value;
    const subtotal  = calcularSubtotal(carrinho);
    const total     = subtotal + (modoEntrega ? TAXA_ENTREGA : 0);
    const divisor   = '--------------';

    let msg = '';
    msg += 'Olá! Vim pelo site da Vereda Cafeteria e gostaria de realizar o seguinte pedido:\n';
    msg += '\n' + divisor + '\n';
    msg += '\n*Nome*: ' + nome + '\n';
    msg += '*Telefone*: ' + tel + '\n';
    msg += '\n*Itens do Pedido*\n';

    carrinho.forEach(item => {
        const subtotalItem = item.preco * item.quantidade;
        msg += '- ' + item.quantidade + 'x ' + item.nome;
        if (item.opcao) msg += ' (' + item.opcao + ')';
        msg += ' - ' + formatarPreco(subtotalItem) + '\n';
    });

    if (modoEntrega) {
        const cidade      = document.getElementById('campo-cidade').value;
        const rua         = document.getElementById('campo-rua').value.trim();
        const numero      = document.getElementById('campo-numero').value.trim();
        const bairro      = document.getElementById('campo-bairro').value.trim();
        const complemento = document.getElementById('campo-complemento').value.trim();

        msg += '\n*Entrega*\n';
        msg += rua + ', ' + numero + ' - ' + bairro + '\n';
        msg += cidade + ' - SP\n';
        if (complemento) msg += 'Referência/Complemento: ' + complemento + '\n';
        msg += '\nTaxa de Entrega: ' + formatarPreco(TAXA_ENTREGA) + '\n';
    } else {
        msg += '\n*Retirada na Vereda*\n';
    }

    msg += '\n*Forma de pagamento*: ' + pagamento + '\n';
    msg += '\n' + divisor + '\n';
    msg += '\n*TOTAL DO PEDIDO*: ' + formatarPreco(total);

    return msg;
}

// --- Confirmar pedido ---

function confirmarPedido() {
    const carrinho = obterCarrinho();
    if (!validar(carrinho)) return;

    mensagemGerada = montarMensagem(carrinho);

    document.getElementById('mensagem-copiavel').textContent = mensagemGerada;

    limparCarrinho();

    document.getElementById('tela-formulario').style.display = 'none';
    document.getElementById('tela-confirmacao').style.display = 'block';
    window.scrollTo({ top: 0, behavior: 'smooth' });

    const url = 'https://wa.me/' + NUMERO_WHATSAPP + '?text=' + encodeURIComponent(mensagemGerada);
    window.open(url, '_blank');
}

// --- Copiar mensagem ---

function copiarMensagem() {
    navigator.clipboard.writeText(mensagemGerada).then(() => {
        const btn = document.querySelector('.btn-copiar');
        const textoOriginal = btn.innerHTML;
        btn.innerHTML = '<i class="ti ti-check"></i> Copiado!';
        setTimeout(() => { btn.innerHTML = textoOriginal; }, 2500);
    }).catch(() => {
        const el = document.createElement('textarea');
        el.value = mensagemGerada;
        document.body.appendChild(el);
        el.select();
        document.execCommand('copy');
        document.body.removeChild(el);
    });
}

// --- Init ---
document.addEventListener('DOMContentLoaded', renderizarResumo);