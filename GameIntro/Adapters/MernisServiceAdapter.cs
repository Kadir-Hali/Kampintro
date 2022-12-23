using GameIntro.Abstract;
using GameIntro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MernisServiceReference.KPSPublicSoapClient;
using MernisServiceReference;

namespace GameIntro.Adapters
{
    internal class MernisServiceAdapter : IPlayerCheckService
    {
        public bool CheckIfRealPerson(Player player)
        {
            long identity = Convert.ToInt64(player.NationalityId);
            KPSPublicSoapClient client = new KPSPublicSoapClient(EndpointConfiguration.KPSPublicSoap);
            var result = client.TCKimlikNoDogrulaAsync(
                identity,
                player.FirstName.ToUpper(),
                player.LastName.ToUpper(),
                player.DateOfBirth.Year
                );
            bool sonuc = result.Result.Body.TCKimlikNoDogrulaResult;
            return sonuc;
        }
    }
}
