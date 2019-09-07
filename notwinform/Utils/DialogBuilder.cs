using MessageBox.Avalonia;
using MessageBox.Avalonia.DTO;
using MessageBox.Avalonia.Enums;
using MessageBox.Avalonia.Models;
using System.Collections.Generic;

namespace NotWinForm.Utils
{
    public static class DialogBuilder
    {
        #region Button Definitions
        public static List<ButtonDefinition> Ok => new List<ButtonDefinition>
            {
                new ButtonDefinition
                {
                    Name = "OK",
                    Type = ButtonType.Colored
                }
            };
        #endregion

        public static MessageBoxWindow SuccessOk(string text = "", string header = "", string title = "", bool center = true)
        {
            var message = MessageBoxWindow.CreateCustomWindow(new MessageBoxCustomParams
            {
                ButtonDefinitions = Ok,
                CanResize = false,
                ShowInCenter = true,
                ContentHeader = header,
                ContentMessage = text,
                Style = Style.DarkMode,
                ContentTitle = title,
                Icon = Icon.Success
            });

            return message;
        }

        public static MessageBoxWindow ErrorOk(string text = "", string header = "", string title = "", bool center = true)
        {
            var message = MessageBoxWindow.CreateCustomWindow(new MessageBoxCustomParams
            {
                ButtonDefinitions = Ok,
                CanResize = false,
                ShowInCenter = true,
                ContentHeader = header,
                ContentMessage = text,
                ContentTitle = title,
                Style = Style.DarkMode,
                Icon = Icon.Error
            });

            return message;
        }
    }
}
