## Como configurar as credenciais

### Cadastro usuário
1. Vá ao console da AWS 
2. Entre e IAM > Users
3. Criar novo usuário
4. Configure as politicas de permissão para "AmazonS3FullAccess"
5. Feito isso, acesse o usuário criado e vá em credenciais de segurança e crie uma "Chave de Acesso"

>guarde o ACCESS_KEY e o ACCESS_SECRET

---
### Login na máquina

1. abra o terminal do computador e digite: 
2. aws configure --profile nome-perfil
3. preencha com os dados de acesso e regiao
4. Para testa pode digitar "aws s3 ls --profile nome-perfil"
---

### Configurando a API
no arquivo appsettings.json da solução configure o perfil nome-perfil e a mesma região do perfil

---
