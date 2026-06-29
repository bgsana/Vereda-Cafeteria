using Vereda_Cafeteria.Models;
using Microsoft.EntityFrameworkCore;

namespace Vereda_Cafeteria.Data.Seeds;

public class SeedProdutoAtelie
{
    public SeedProdutoAtelie(ModelBuilder builder)
    {
        List<Produto> produtos = new List<Produto>
        {
            #region Canecas (CategoriaId = 6)

            new Produto
            {
                ProdutoId = 41,
                CategoriaId = 6,
                Nome = "Caneca Cachorro",
                Descricao = "Caneca de cerâmica 3D com rosto de cachorro modelado na lateral. Fofa, resistente e cheia de personalidade, para tomar café com o melhor amigo do lado.",
                QtdEstoque = 5,
                Preco = 69.90m,
                ImagemUrl = "/img/produtos/atelie/canecas/caneca-cachorro.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 42,
                CategoriaId = 6,
                Nome = "Caneca Capivara",
                Descricao = "Caneca de cerâmica 3D com rosto de capivara modelado na lateral. Tranquila, simpática e inconfundível, para quem leva a sério o modo capivara de viver.",
                QtdEstoque = 5,
                Preco = 69.90m,
                ImagemUrl = "/img/produtos/atelie/canecas/caneca-capivara.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 43,
                CategoriaId = 6,
                Nome = "Caneca Gato",
                Descricao = "Caneca de cerâmica 3D com rosto de gato modelado na lateral. Elegante, expressiva e um pouco misteriosa, assim como todo bom felino que se preze.",
                QtdEstoque = 5,
                Preco = 69.90m,
                ImagemUrl = "/img/produtos/atelie/canecas/caneca-gato.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 44,
                CategoriaId = 6,
                Nome = "Caneca Raposa",
                Descricao = "Caneca de cerâmica 3D com rosto de raposa modelado na lateral. Charmosa, detalhada e com aquele olhar esperto que conquista antes mesmo do primeiro café.",
                QtdEstoque = 5,
                Preco = 69.90m,
                ImagemUrl = "/img/produtos/atelie/canecas/caneca-raposa.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 45,
                CategoriaId = 6,
                Nome = "Caneca Tubarão",
                Descricao = "Caneca de cerâmica 3D com rosto de tubarão modelado na lateral. Divertida, inusitada e garantida de arrancar sorrisos, para o café mais ousado do dia.",
                QtdEstoque = 5,
                Preco = 69.90m,
                ImagemUrl = "/img/produtos/atelie/canecas/caneca-tubarao.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 46,
                CategoriaId = 6,
                Nome = "Caneca Dinossauro",
                Descricao = "Caneca de cerâmica 3D com rosto de dinossauro modelado na lateral. Pré-histórica no visual, atual no estilo, para quem quer um café com muita atitude.",
                QtdEstoque = 5,
                Preco = 69.90m,
                ImagemUrl = "/img/produtos/atelie/canecas/caneca-dinossauro.png",
                Ativo = true
            },

            #endregion

            #region Crochê (CategoriaId = 7)

            new Produto
            {
                ProdutoId = 47,
                CategoriaId = 7,
                Nome = "Buquê de Girassol Porta-Copo",
                Descricao = "Buquê de girassóis em crochê artesanal que se transforma em porta-copo. Alegre, funcional e cheio de sol, um presente que decora e ainda tem utilidade.",
                QtdEstoque = 3,
                Preco = 54.90m,
                ImagemUrl = "/img/produtos/atelie/croche/buque-girassol-porta-copo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 48,
                CategoriaId = 7,
                Nome = "Água-Viva",
                Descricao = "Água-viva em crochê artesanal nas cores azul e branco, com tentáculos delicados e textura encantadora. Delicada, flutuante e cheia de poesia nas mãos de quem a fez.",
                QtdEstoque = 3,
                Preco = 49.90m,
                ImagemUrl = "/img/produtos/atelie/croche/agua-viva.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 49,
                CategoriaId = 7,
                Nome = "Bob com Ursinho Tim",
                Descricao = "Bob do Minions abraçando o ursinho Tim, feito em crochê artesanal com detalhes caprichados. Fofura em dose dupla, para quem ama os dois personagens de coração.",
                QtdEstoque = 3,
                Preco = 64.90m,
                ImagemUrl = "/img/produtos/atelie/croche/bob-ursinho-tim.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 50,
                CategoriaId = 7,
                Nome = "Mike Wazowski",
                Descricao = "Mike Wazowski em crochê artesanal com detalhes fiéis ao personagem. Verde, redondo e cheio de expressão, para os fãs de Monstros S.A. que levam o afeto a sério.",
                QtdEstoque = 3,
                Preco = 59.90m,
                ImagemUrl = "/img/produtos/atelie/croche/mike-wazowski.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 51,
                CategoriaId = 7,
                Nome = "Casal de Sapinhos",
                Descricao = "Casal de sapinhos em crochê artesanal, ela de saia e ele de gravata. Charmosos, coloridos e feitos com muito cuidado, um presente perfeito para celebrar o amor.",
                QtdEstoque = 3,
                Preco = 59.90m,
                ImagemUrl = "/img/produtos/atelie/croche/casal-sapinhos.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 52,
                CategoriaId = 7,
                Nome = "Stitch",
                Descricao = "Stitch em crochê artesanal com detalhes fiéis ao personagem. Azul, orelhas grandes e irresistível, para quem sabe que o verdadeiro lar é onde o Stitch está.",
                QtdEstoque = 3,
                Preco = 59.90m,
                ImagemUrl = "/img/produtos/atelie/croche/stitch.png",
                Ativo = true
            },

            #endregion

            #region Bonecos de Feltro (CategoriaId = 8)

            new Produto
            {
                ProdutoId = 53,
                CategoriaId = 8,
                Nome = "Papai Noel",
                Descricao = "Papai Noel artesanal em feltro com detalhes costurados à mão. Aconchegante, encantador e cheio de espírito natalino, para enfeitar com muito carinho e afeto.",
                QtdEstoque = 5,
                Preco = 44.90m,
                ImagemUrl = "/img/produtos/atelie/feltro/papai-noel.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 54,
                CategoriaId = 8,
                Nome = "Raposa",
                Descricao = "Raposa artesanal em feltro com detalhes costurados à mão. Charmosa, expressiva e muito cuidadosa nos detalhes, um item que vira queridinha de qualquer prateleira.",
                QtdEstoque = 5,
                Preco = 39.90m,
                ImagemUrl = "/img/produtos/atelie/feltro/raposa.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 55,
                CategoriaId = 8,
                Nome = "Ursinho",
                Descricao = "Ursinho artesanal em feltro com detalhes costurados à mão. Delicado, carinhoso e com um visual encantador, perfeito para decorar e transmitir aconchego em qualquer cantinho.",
                QtdEstoque = 5,
                Preco = 39.90m,
                ImagemUrl = "/img/produtos/atelie/feltro/ursinho.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 56,
                CategoriaId = 8,
                Nome = "Dinossauro",
                Descricao = "Dinossauro artesanal em feltro com detalhes costurados à mão. Divertido, robusto e impossível de não amar, perfeito para crianças e adultos que nunca cresceram.",
                QtdEstoque = 5,
                Preco = 39.90m,
                ImagemUrl = "/img/produtos/atelie/feltro/dinossauro.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 57,
                CategoriaId = 8,
                Nome = "Ovelha",
                Descricao = "Ovelha artesanal em feltro com detalhes costurados à mão. Fofinha, branquinha e muito bem acabada, aquela peça que faz qualquer ambiente ficar mais aconchegante.",
                QtdEstoque = 5,
                Preco = 39.90m,
                ImagemUrl = "/img/produtos/atelie/feltro/ovelha.png",
                Ativo = true
            },

            #endregion

            #region Livros (CategoriaId = 9)

            new Produto
            {
                ProdutoId = 58,
                CategoriaId = 9,
                Nome = "O que é PCD?",
                Descricao = "Livro de Gabriela dos Santos Guimarães que explica de forma acessível o que significa ser uma Pessoa com Deficiência. Leitura essencial para construir um mundo mais inclusivo.",
                QtdEstoque = 5,
                Preco = 42.00m,
                ImagemUrl = "/img/produtos/atelie/livros/o-que-e-pcd.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 59,
                CategoriaId = 9,
                Nome = "A Capivara Autista",
                Descricao = "Livro de Gabriela dos Santos Guimarães que aborda o autismo com leveza e sensibilidade através de uma capivara. Uma história que acolhe, explica e aproxima.",
                QtdEstoque = 5,
                Preco = 42.00m,
                ImagemUrl = "/img/produtos/atelie/livros/capivara-autista.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 60,
                CategoriaId = 9,
                Nome = "Ser Autista",
                Descricao = "Livro de Gabriela dos Santos Guimarães sobre a experiência de ser autista no mundo. Um relato honesto, humano e necessário para quem quer entender de verdade.",
                QtdEstoque = 5,
                Preco = 42.00m,
                ImagemUrl = "/img/produtos/atelie/livros/ser-autista.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 61,
                CategoriaId = 9,
                Nome = "Contra o Capacitismo",
                Descricao = "Livro de Gabriela dos Santos Guimarães que questiona e combate o capacitismo na sociedade. Direto, corajoso e transformador, uma leitura que muda perspectivas.",
                QtdEstoque = 5,
                Preco = 42.00m,
                ImagemUrl = "/img/produtos/atelie/livros/contra-capacitismo.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 62,
                CategoriaId = 9,
                Nome = "Timoti",
                Descricao = "Livro de Gabriela dos Santos Guimarães sobre Timoti, uma capivara neurodivergente. Afetuoso, representativo e cheio de cuidado com quem se vê nessa história.",
                QtdEstoque = 5,
                Preco = 42.00m,
                ImagemUrl = "/img/produtos/atelie/livros/timoti.png",
                Ativo = true
            },

            #endregion

            #region Velas (CategoriaId = 10)

            new Produto
            {
                ProdutoId = 63,
                CategoriaId = 10,
                Nome = "Vela Aromática Baunilha",
                Descricao = "Vela aromática com aroma de baunilha, clássico e aconchegante. Suave, adocicado e familiar, para transformar qualquer ambiente numa experiência de conforto.",
                QtdEstoque = 5,
                Preco = 29.90m,
                ImagemUrl = "/img/produtos/atelie/velas/vela-baunilha.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 64,
                CategoriaId = 10,
                Nome = "Vela Aromática Lavanda",
                Descricao = "Vela aromática com aroma de lavanda, fresco e purificante. Transforma o ambiente com leveza e serenidade, trazendo conforto e bem-estar para o seu espaço.",
                QtdEstoque = 5,
                Preco = 29.90m,
                ImagemUrl = "/img/produtos/atelie/velas/vela-lavanda.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 65,
                CategoriaId = 10,
                Nome = "Vela Aromática Limão-Verbena",
                Descricao = "Vela aromática com aroma de limão e verbena, calmante e revigorante. Para os momentos de cansaço, acalma o corpo e a mente e ainda convida a um sono tranquilo.",
                QtdEstoque = 5,
                Preco = 29.90m,
                ImagemUrl = "/img/produtos/atelie/velas/vela-limao-verbena.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 66,
                CategoriaId = 10,
                Nome = "Vela Aromática Rosa",
                Descricao = "Vela aromática com aroma de rosa, romântico e delicado. Para os momentos de ansiedade ou agitação, a fragrância floral traz relaxamento e leveza ao ambiente.",
                QtdEstoque = 5,
                Preco = 29.90m,
                ImagemUrl = "/img/produtos/atelie/velas/vela-rosa.png",
                Ativo = true
            },
            new Produto
            {
                ProdutoId = 67,
                CategoriaId = 10,
                Nome = "Vela Aromática Manga",
                Descricao = "Vela aromática com aroma de manga, tropical e vibrante. Frutada, alegre e cheia de vida, para trazer um toque de verão e bom humor a qualquer ambiente.",
                QtdEstoque = 5,
                Preco = 29.90m,
                ImagemUrl = "/img/produtos/atelie/velas/vela-manga.png",
                Ativo = true
            },

            #endregion
        };

        builder.Entity<Produto>().HasData(produtos);
    }
}
