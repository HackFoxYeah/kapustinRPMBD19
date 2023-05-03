namespace kapustinRPMBD18
{
    using System.Data.Entity;
    public partial class Entity : DbContext
    {
        private static Entity _context;
        public static Entity GetContext()
        {
            if (_context == null)
                _context = new Entity();
            return _context;
        }
    }
}