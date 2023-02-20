using Microsoft.Toolkit.Uwp.Notifications;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           new ToastContentBuilder()
                .AddArgument("action", "viewConversation")
                .AddArgument("conversationId", 9813)
                .AddText("Andrew sent you a picture")
                .AddText("Check this out, The Enchantments in Washington!")
                .Show();
           ToastNotificationManagerCompat.OnActivated += toastArgs =>
           {
               // Obtain the arguments from the notification
               ToastArguments args = ToastArguments.Parse(toastArgs.Argument);

               // Obtain any user input (text boxes, menu selections) from the notification
               var userInput = toastArgs.UserInput;

            
           };
        }
    }
}