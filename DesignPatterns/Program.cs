// See https://aka.ms/new-console-template for more information
using Singleton;
using Builder;

/*Singleton*/

////primera vezcria a instancia

//var con1 = Conexao.GetInstance();

////depois só retorna a instacia criada
//var con2 = Conexao.GetInstance();

/*Builder*/

MediaSocialBuilder builder = new MediaSocialFacebookBuilder();
builder.BuildPost();
builder.BuildLike();

builder = new MediaSocialTwitterBuilder();
builder.BuildPost();
builder.BuildLike();
Console.ReadKey();
