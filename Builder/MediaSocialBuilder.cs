using Domain;

namespace Builder
{
    public abstract class MediaSocialBuilder
    {
        protected MediaSocial _mediaSocial;
        public MediaSocial MediaSocial => _mediaSocial;        

        public abstract void BuildPost();

        public abstract void BuildLike();

    }
}