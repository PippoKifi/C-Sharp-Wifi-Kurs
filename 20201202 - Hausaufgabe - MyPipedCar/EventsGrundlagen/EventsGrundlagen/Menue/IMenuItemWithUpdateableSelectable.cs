namespace MyPimpedCar
{
    public interface IMenuItemWithUpdateableSelectable<T> : IMenuItem<T>
    {
        void UpdateSelectable(bool newValue);
    }
}