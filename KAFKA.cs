using System;
using Confluent.Kafka;

class Program
{
    static void Main(string[] args)
    {
        var config = new ProducerConfig
        {
            BootstrapServers = "dad-puc-bianca.servicebus.windows.net",
            SaslMechanism = SaslMechanism.Plain,
            SecurityProtocol = SecurityProtocol.SaslSsl,
            SaslUsername = "$ConnectionString",
            SaslPassword = "Endpoint=sb://dad-puc-bianca.servicebus.windows.net/;SharedAccessKeyName=dad-kafka producer;SharedAccessKey=msRKvuY2nPlFUaYKoOl8KjXa+NVoxk1ST+AEhO1gbnM=",
            ClientId = "dotnet-producer"
        };

        using (var producer = new ProducerBuilder<Null, string>(config).Build())
        {
            string topic = "dad-kafka";

            var message = new Message<Null, string>
            {
                Value = "{\"name\": \"Bianca Larisse Cordeiro de Moura\", \"login_id\": \"1308416@sga.pucminas.br\", \"group\": 1}"
            };

            producer.Produce(topic, message, deliveryReport =>
            {
                if (deliveryReport.Error.IsError)
                {
                    Console.WriteLine($"Erro: {deliveryReport.Error.Reason}");
                }
                else
                {
                    Console.WriteLine($"Mensagem enviada para: {deliveryReport.TopicPartitionOffset}");
                }
            });

            producer.Flush(TimeSpan.FromSeconds(10));
        }
    }
}
