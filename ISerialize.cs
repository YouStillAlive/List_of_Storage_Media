using System.Collections.Generic;
namespace List_of_Storage_Media
{
    public interface ISerialize
    {
        void Save(List<Storage> value);
        List<Storage> Load();
    }
}
