namespace DesignPatterns.CreationalPatterns.Prototype.Keynote
{
    public class ContextMenu
    {
        public IComponent Duplicate(IComponent component)
        {
            var newComponent = component.Clone();
            // Add target to our document

            return newComponent;
        }
    }
}
