using System.Security.Cryptography.X509Certificates;

namespace SnekBox
{
    public interface IGoodsOperations
    {
        int ChoiceGoods(int input);
        void DeployGoods();

    }
}