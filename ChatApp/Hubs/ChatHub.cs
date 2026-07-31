using Microsoft.AspNetCore.SignalR; //brings in SignalR's base classes and interfaces, including the Hub class, which is the base class for creating SignalR hubs.


namespace ChatApp.Hubs // Organizes the code into a namespace called ChatApp.Hubs, which helps avoid naming conflicts and logically groups related classes together.
{
    public class ChatHub : Hub // Inherits the Hub class from SignalR, allowing it to handle real-time communication between clients and the server.
    {
        public async Task SendMessage(string user, string message) // Defines an asynchronous method named SendMessage that takes two parameters: user and message. This method will be called by clients to send messages to the hub.
        {
            // Client.All means that the message will be sent to all connected clients. The SendAsync method is used to invoke a client-side method named ReceiveMessage, passing the user and message parameters to it.
            // The ReceiveMessage method is expected to be implemented on the client side to handle the incoming messages and update the user interface accordingly.
            // The await keyword is used to asynchronously wait for the SendAsync operation to complete, ensuring that the method does not block the execution of other code while waiting for the message to be sent.
            await Clients.All.SendAsync("ReceiveMessage", user, message); 
        }
    }
}

    

    

