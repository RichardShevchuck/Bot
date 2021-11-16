using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types;

namespace NewBot
{
    class Program
    {
        static TelegramBotClient Bot = new TelegramBotClient("1430099168:AAGk4_O396ksz3vlHLAJTwrODD3MCl041zQ");
        static void Main(string[] args)
        {
            Bot.StartReceiving();
            Bot.OnMessage += Bot_OnMessage;
            

            Console.ReadLine();
        }

        private static void Bot_OnMessage(object? sender, MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
            {
                Bot.SendPhotoAsync(e.Message.Chat.Id, new InputMedia("https://inlnk.ru/n0NGe"));
            }
        }
    }
}