# kafka

Este trabalho envolve a implementação de um produtor Kafka em C# usando a biblioteca Confluent.Kafka. O objetivo é enviar mensagens para um tópico chamado "dad-kafka" hospedado em um cluster Kafka no serviço Azure Service Bus.

O programa utiliza as informações de conexão fornecidas, incluindo o endereço do host, credenciais de autenticação (usando SASL/PLAIN com SSL), e um formato específico de mensagem em JSON. O produtor Kafka é configurado para se conectar ao broker hospedado no endereço "dad-puc-bianca.servicebus.windows.net:9093".

A mensagem a ser enviada é um objeto JSON com campos como "name", "login_id" e "group". Após enviar a mensagem, o programa imprime no console se a operação foi bem-sucedida ou se houve algum erro durante o processo de envio.

Requisitos e Notas Importantes:

Certifique-se de que a biblioteca Confluent.Kafka esteja instalada no projeto para utilizar as funcionalidades do Kafka em C#.
As informações de autenticação (usuário, senha, endpoint) devem ser precisas para garantir uma conexão segura e bem-sucedida ao cluster Kafka no Azure Service Bus.
O formato da mensagem JSON deve estar de acordo com as expectativas do consumidor do tópico "dad-kafka".
A execução bem-sucedida do programa depende de permissões adequadas no cluster Kafka e no namespace do Azure Service Bus para enviar mensagens para o tópico especificado.
