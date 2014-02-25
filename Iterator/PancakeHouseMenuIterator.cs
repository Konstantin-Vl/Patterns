using System.Collections;

namespace Iterator
{
    public class PancakeHouseMenuIterator:IIterator
    {
        private readonly ArrayList _menuItems;
        private int _position;

        public PancakeHouseMenuIterator(ArrayList menuItems)
        {
            _menuItems = menuItems;
        }

        public bool HasNext()
        {
            return _menuItems != null && _position < _menuItems.Count && _menuItems[_position] != null;
        }

        public object Next()
        {
            var menuItem = _menuItems[_position];
            _position++;
            return menuItem;
        }
    }
}
