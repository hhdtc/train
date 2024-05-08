using Azure.Messaging.ServiceBus;
using Azure.Storage.Queues;
using System.Text;
using System.Text.Json;

namespace OrderApi.MessagingService
{
    public class QueueService
    {
        private readonly IConfiguration _config;
        public QueueService(IConfiguration configuration) {
            _config = configuration;
        }

        public async Task SendMessageAsync<T>(T message, string queueName) {
            //var queueClient =new QueueClient(_config.GetConnectionString("AzureServiceBus"),queueName);
            var queueClient = new ServiceBusClient(_config.GetConnectionString("AzureServiceBus"));
            var sender = queueClient.CreateSender(queueName);
            string messageBody = JsonSerializer.Serialize(message);
            var messageData = new ServiceBusMessage(Encoding.UTF8.GetBytes(messageBody));
            sender.SendMessageAsync(messageData);

        }

        public async Task<T> ReadMessageAsync<T>(string queueName) {
            var queueClient = new ServiceBusClient(_config.GetConnectionString("AzureServiceBus"));
            queueClient.CreateReceiver(queueName);
            var receiver = queueClient.CreateReceiver(queueName);
            var message = await receiver.ReceiveMessageAsync();
            var encodedstring = Encoding.UTF8.GetString(message.Body);
            T result = JsonSerializer.Deserialize<T>(encodedstring);
            return result;
        }
    }
}
