

using Domain;

namespace Builder
{
    public class MediaSocialTwitterBuilder : MediaSocialBuilder
    {
        public MediaSocialTwitterBuilder()
        {
            _mediaSocial = new MediaSocial("Twitter", ConsoleColor.DarkCyan);
        }

        public override void BuildLike()
        {
            _mediaSocial.Like($"Minha Primeira Publicação");
        }

        public override void BuildPost()
        {
            _mediaSocial.Post("Minha Primeira Publicação","Aqui está minha publicação");
        }
    }
}
