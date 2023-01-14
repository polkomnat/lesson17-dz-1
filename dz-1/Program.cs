using System;


namespace dz_1
{
    internal class Program
    {
        static void Main(string[] args)
        {


            {
                bool exit = false;
                TV tV = new TV();
                Console.WriteLine("TV");
                Console.WriteLine("N - Next channel");
                Console.WriteLine("P - Prev channel");
                Console.WriteLine("G - Go to channel");
                Console.WriteLine("E - Exit");
                int currentChannel = tV.MoveToChannel(0);
                int current = 0;
                while (true)
                {
                    string key = Console.ReadLine();
                    switch (key)
                    {
                        case "e": 
                            exit = true;
                            break;
                        case "n": 
                            currentChannel++;
                            current = tV.NextChannel(currentChannel);
                            currentChannel = current;
                            break;
                        case "p":
                            currentChannel--;
                            current = tV.PreviousChannel(currentChannel);
                            currentChannel = current;
                            break;
                        case "g":
                            current = tV.MoveToChannel(Convert.ToInt32(Console.ReadLine()));
                            currentChannel = current;
                            break;
                    }
                    if (exit == true) break;
                }
                Console.ReadKey();
            }
        }
        public class TV
        {
            public string currentChannel { get; set; }
            public int channelLimit { get; set; }
            public TV()
            {
                tv = new TV[]
                {
            new TV("0.ТНТ"),
            new TV("1.СТС"),
            new TV("2.КТРК"),
            new TV("3.ССТВ"),
            new TV("4.РЕНТВ"),
            new TV("5.МТВ")
                };
            }
            public TV(string channel)
            {
                currentChannel = channel;
            }
            public TV(string channel, int count)
            {
                currentChannel = channel;
                channelLimit = count;
            }
            public int NextChannel(int channel)
            {
                int result;
                if (channel == tv.Length)
                    result = 0;
                else
                    result = channel;
                Console.WriteLine(tv[result].currentChannel);
                return result;
            }
            public int PreviousChannel(int channel)
            {
                int result;
                if (channel == -1)
                    result = channel + tv.Length;
                else
                    result = channel;
                Console.WriteLine(tv[result].currentChannel);
                return result;
            }
            public int MoveToChannel(int channel)
            {
                Console.WriteLine(tv[channel].currentChannel);
                return channel;
            }
            TV[] tv;
            public string this[int index]
            {
                get
                {
                    TV channel = null;
                    for (int i = 0; i < tv.Length; i++)
                    {
                        if (i == index)
                        {
                            channel = tv[index];
                            break;
                        }
                    }
                    return channel.currentChannel;
                }
                set
                {
                    for (int i = 0; i < tv.Length; i++)
                    {
                        if (i == index)
                        {
                            tv[index].currentChannel = value;
                            break;
                        }
                    }
                }
            }
        }
    }
}
