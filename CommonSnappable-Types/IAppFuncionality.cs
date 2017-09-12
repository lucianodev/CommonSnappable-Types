using System;


namespace CommonSnappableTypes
{
    //IAppFuncionality
    public interface IAppFuncionality
    {
        void DoIt();
    }

    //criando um atributo personalizado para colocar as informacoes do desenvolvedor.
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class CompanyInfoAttibute : System.Attribute
    {
        private string _name;
        private string _url;
        public String Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public String Url
        {
            get { return _url; }
            set { _url = value; }
        }
    }
}
