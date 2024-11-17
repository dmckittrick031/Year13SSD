using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace AdventCalendarTask.Assets
{
    internal class Serializer
    {
        public static bool SerializePlayer(Player player)
        {
			try
			{
				using (Stream stream = File.Open("SerializedPlayer.bin", FileMode.Create))
				{
					BinaryFormatter bf = new();
					bf.Serialize(stream, player);
					return true;
				}
			}
			catch (Exception)
			{
                return false;
			}
        }

		public static Player DeserializePlayer()
		{
			try
			{
				using (Stream stream = File.Open("SerializedPlayer.bin", FileMode.Open))
				{
					BinaryFormatter bf = new();
					Player playerDeserialized = (Player)bf.Deserialize(stream);
					return playerDeserialized;
				}
			}
			catch (Exception)
			{
				return null;
			}
		}
    }
}
