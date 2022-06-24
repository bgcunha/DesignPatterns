

using Domain;

namespace Builder
{
    public class MediaSocialFacebookBuilder : MediaSocialBuilder
    {
        public MediaSocialFacebookBuilder()
        {
            _mediaSocial = new MediaSocial("Facebook", ConsoleColor.Blue);
        }

        public override void BuildLike()
        {
            _mediaSocial.Like("Minha Primeira Publicação");
        }

        public override void BuildPost()
        {
            _mediaSocial.Post("Minha Primeira Publicação","Aqui está minha publicação");
        }
    }
}
