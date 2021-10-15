using System.IO;
using System.Threading.Tasks;

namespace SudorouxTest.BL.IServices
{
    public interface ICustomHelpers
    {
        Task<MemoryStream> PostExternalApi<T>(T model,string url);
    }
}