namespace Projeto1;

public partial class GamePage : ContentPage
{

	List<PassoHistoria> historia = new List<PassoHistoria>();
  PassoHistoria PassoAtualHistoria;


	public GamePage()
	{
		InitializeComponent();

    historia.Add(new PassoHistoria()
    {
      Id = 0,
      Texto = "Havia um certo Aventureiro nomeado Stuart, em uma certa noite Stuart se perdeu em uma floresta nevoada que havia a caminho de sua casa. Ele então viu uma pedra rúnica brilhante no chão, e ficou indeciso se iria colocar a mão ou não ",
      TemResposta=false
    });
    historia.Add(new PassoHistoria()
    {
      Id = 1,
      Texto = "Oque ele faz?",
      TemResposta=true,
      TextoResposta1="Ignora ela",
      TextoResposta2="Chuta ela",
      TextoResposta3="Tenta rouba-la",
      IdResposta1=2,
      IdResposta2=18,
      IdResposta3=20
    });
    historia.Add(new PassoHistoria()
    {
      Id = 2,
      Texto = "Ele mesmo muito curioso a ignora e segue em frente",
      TemResposta=false,
    });
    historia.Add(new PassoHistoria()
    {
      Id = 3,
      Texto = "Ele consegue sair da Foresta com vida",
      TemResposta=false,
    });
    historia.Add(new PassoHistoria()
    {
      Id = 4,
      Texto = "(Final Feliz) ele volta pra sua casa em segurança",
      TemResposta=false,
    });
    historia.Add(new PassoHistoria()
    {
      Id = 5,
      Texto = "(Obrigado por Jogar 👍)",
      GameOver=true
    });
    historia.Add(new PassoHistoria()
    {
      Id = 18,
      Texto = "Ele sente seu corpo em ardência no início mas ignora, pensando que está com dor de barriga",
      TemResposta=false,
    });
    historia.Add(new PassoHistoria()
    {
      Id = 19,
      Texto = "(Morreu 1) ele sente a presença rúnica tomando sua alma e logo após a sua alma é dissolvida e devorada pela runa",
      TemResposta=false,
      GameOver=true
    });
    historia.Add(new PassoHistoria()
    {
      Id = 20,
      Texto = "(Morreu 2) a Runa absorve seu corpo e o deixa ele queimar e sofrer em chamas verdes mágicas, fazendo o grunhir e agoniar até sua Morte ",
      TemResposta=false,
      GameOver=true
    });

    Iniciar();
	}


//.......................................................................................................

   void Iniciar()
  {
    TrocaPassoAtualHistoria(0);
  }

  //.......................................................................................................

  void PreencherPagina()
  {
    LabelTexto.Text = PassoAtualHistoria.Texto;

    if (PassoAtualHistoria.GameOver)
      FrameGameOver.IsVisible = true;
    else
      FrameGameOver.IsVisible = false;

    if (PassoAtualHistoria.TemResposta)
    {
      BotaoContinuar.IsVisible = false;
      BotaoResposta1.IsVisible = true;
      BotaoResposta2.IsVisible = true;
      BotaoResposta3.IsVisible = true;
      BotaoResposta1.Text = PassoAtualHistoria.TextoResposta1;
      BotaoResposta2.Text = PassoAtualHistoria.TextoResposta2;
      BotaoResposta3.Text = PassoAtualHistoria.TextoResposta3;
    }
    else
    {
      BotaoContinuar.IsVisible = true;
      BotaoResposta1.IsVisible = false;
      BotaoResposta2.IsVisible = false;
      BotaoResposta3.IsVisible = false;
    }
  }

  //.......................................................................................................

  void TrocaPassoAtualHistoria(int id)
  {
    PassoAtualHistoria = historia.Where(d => d.Id == id).First();
    PreencherPagina();
  }

  //.......................................................................................................

  void BotaoContinuarClick(object sender, EventArgs args)
  {
    var proximoId = PassoAtualHistoria.Id + 1;
    TrocaPassoAtualHistoria(proximoId);
  }

  //.......................................................................................................

  void Botao1Click(object sender, EventArgs args)
  {
    TrocaPassoAtualHistoria(PassoAtualHistoria.IdResposta1);
  }

  //.......................................................................................................

  void Botao2Click(object sender, EventArgs args)
  {
    TrocaPassoAtualHistoria(PassoAtualHistoria.IdResposta2);
  }

  //.......................................................................................................

  void Botao3Click(object sender, EventArgs args)
  {
    TrocaPassoAtualHistoria(PassoAtualHistoria.IdResposta3);
  }

  //.......................................................................................................

  void BotaoGameOverClick(object sender, EventArgs args)
  {
    Iniciar();
  }

}