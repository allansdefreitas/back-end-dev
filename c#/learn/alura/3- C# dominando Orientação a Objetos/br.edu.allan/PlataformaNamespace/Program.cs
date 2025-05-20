/* Como distinguir entre classes homônimas de namespaces diferentes */

// PlataformaNamespace.PlataformaA.Video video = new("nomeVideo");
// PlataformaNamespace.PlataformaB.Video video2 = new(1);

// Console.WriteLine("teste");

/* Outra forma de distinguir entre classes homônimas de namespaces diferentes */

using VideoA = PlataformaNamespace.PlataformaA.Video; //criei um apelido para o Video da plataforma A
using VideoB = PlataformaNamespace.PlataformaB.Video; //criei um apelido para o Video da plataforma B

VideoA video1 = new("titulo");
VideoB video2 = new(1);


Console.WriteLine("teste2");

