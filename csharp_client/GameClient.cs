using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

public class GameClient : Form
{
    private readonly HttpClient _client = new HttpClient();

    public GameClient()
    {
        Load += async (sender, e) => await ConnectToServer();
    }

    private async Task ConnectToServer()
    {
        var response = await _client.GetStringAsync("http://127.0.0.1:3030/game");
        MessageBox.Show(response);
    }
    
    [STAThread]
    public static void Main()
    {
        Application.Run(new GameClient());
    }
}
