#!/bin/bash

# Com as configurações atuais, o client faz uma requisição por segundo,
# Para aumentar o número de requisições por segundo, descomente as linhas
# 14 e 32 e comente a linha 33, você terá que remover tanto a imagem como
# o container client-forum-api e subir a stack novamente para o rebuild.

HOST='proxy-forum-api'

while true; do
    ENDP=$(expr $RANDOM % 3 + 1)
    NUMB=$(expr $RANDOM % 100 + 1)
    #TEMP=$(expr 1 + $(awk -v seed="$RANDOM" 'BEGIN { srand(seed); printf("%.4f\n", rand()) }'))
    
    if [ $NUMB -le 50 ]; then
        curl --silent --output /dev/null "http://${HOST}/topicos" #GET de todos os tópicos
    
    elif [ $NUMB -ge 51 ] && [ $NUMB -le 80 ]; then #GET de tópico existente
        curl --silent --output /dev/null "http://${HOST}/topicos/$ENDP"

    elif [ $NUMB -ge 81 ] && [ $NUMB -le 90 ]; then #login com sucesso
        curl --silent --output /dev/null \
            --data '{"email":"moderador@email.com","senha":"123456"}' \
            --header "Content-Type:application/json" \
            --request POST \
            "http://${HOST}/auth"
    
    elif [ $NUMB -ge 91 ] && [ $NUMB -le 95 ]; then #login com erro
        curl --silent --output /dev/null \
            --data '{"email":"moderador@email.com","senha":"1234567"}' \
            --header "Content-Type:application/json" \
            --request POST \
            "http://${HOST}/auth"
    
    else
        curl --silent --output /dev/null "http://${HOST}/topicos/0" #GET de tópico inexistente, retorna 404
    fi

    #sleep $TEMP
    sleep 0.75
done