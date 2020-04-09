namespace DesignPatterns.StructuralPatterns.Proxy.EbookReader.EbookDomain
{
    public interface IEbook
    {
        string FileName { get; }        
        void Show();
    }
}