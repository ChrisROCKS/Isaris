namespace Isaris
{
    public class FormFactory
    {
        public FormFactory()
        {
        }

        public T Create<T>() where T : class 
        {
            return CompositionRoot.Resolve<T>();
        }

        
    }
}
