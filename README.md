# desafio-hammer-dotnet
Aqui na hammer organizamos um churras todos os meses, **é necessario que cada funcionario contribua 20$ e se quiser levar um convidado 40$**. O problema é que não temos uma maneira para controlar quem irá no churrasco e quanto foi gasto com comida e bebida. **Um funcionário pode levar apenas um convidado,se você não beber,o valor do churrasco será metade,a mesma regra é valida para o convidado**.
Dado o problema é necessario desenvolver uma aplicação WebApi para consumo do nosso front.


# Tecnologias
* **FrameWork** : .Net core 2.x
* **Database**: Sql server ou outro.
* **Arquitetura e Design Patterns**: da sua preferencia mas de acordo com o problema.


# EndPoints Necessários
* Participar do Churrasco. (api/churrasco/criarparticipante)\
* Cancelar participação do Churrasco. (api/churrasco/removeparticipante/{id})\
* Cancelar participação do convidado no Churrasco. (api/churrasco/removeparticipante/{id})\
* Total Arrecadado. (api/churrasco/retornatotalarrecadado)\
* Listar Participantes. (api/churrasco/retornaempregados)\
* Listar Convidados. (api/churrasco/retornacandidatos)\
* Total Gasto. (api/churrasco/retornatotalarrecadado)\
* Total Gasto em Comida. (api/churrasco/retornatotalbebida)\
* Total Gasto em Bebida. (api/churrasco/retornatotalcomida)\
* Listar Participantes Desistentes. (api/churrasco/retornacancelados)\



********
