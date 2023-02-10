from operator import truediv
from kafka import KafkaProducer
import time
# the bootstrap server is the address of the kafka broker, i.e. the docker container. Here you can specify multiple brokers 
# separated by a comma to enable load balancing and fault tolerance.producer = KafkaProducer(bootstrap_servers='kafka1:9092')
producer = KafkaProducer(bootstrap_servers='kafka1:9092')

# change the producer to read from alice-in-wonderland.txt and publish content one line at a time
with open('alice-in-wonderland-short.txt', 'r') as f:
     for line in f:
         producer.send('foobar', line.encode('utf-8'))
         time.sleep(1)
         producer.flush()

"""
exit = False
while not exit:
    msg = input("Enter a message: ")
    if(input == "exit"):
        exit == True
        break
    # send the message to the topic 'foobar'
    producer.send('foobar', msg.encode('utf-8'))
    producer.flush()
"""