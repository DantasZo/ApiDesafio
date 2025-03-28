<h2>Funcionalidades</h2>
<ul>
    <li><strong>Geração de Sequência Aleatória</strong>: A API gera uma sequência aleatória de caracteres e números.</li>
    <li><strong>Verificação de Tentativas</strong>: Os usuários podem enviar tentativas para verificar se a sequência está correta.</li>
    <li><strong>Registro de Sequência Correta</strong>: A sequência correta é registrada em um arquivo de log.</li>
</ul>

<h2>Estrutura do Projeto</h2>
<pre><code>
ApiDesafio/
│-- Program.cs               # Configuração e inicialização do aplicativo
│-- Controller.cs            # Controlador que gerencia as requisições HTTP e a lógica de verificação
│-- appsettings.json         # Configurações do aplicativo
│-- ApiDesafio.http          # Arquivo de exemplo para testar a API
│-- Senha/senha.txt          # Arquivo onde as sequências corretas são registradas
<h2>Endpoints</h2>
<h3>POST /api/Desafio</h3>
<p>Envia uma tentativa para verificar se a sequência está correta.</p>

<h4>Request</h4>
<pre><code>
POST http://localhost:5100/api/Desafio
Content-Type: application/json

{
"Key": "sequencia_a_ser_testada",
"grupo": "nome_do_grupo"
}
<h4>Response</h4>
<p><strong>200 OK</strong>: Retorna uma mensagem indicando se a tentativa foi bem-sucedida ou não.</p>

<h2>Configuração e Execução</h2>
<ol>
    <li>Clone o repositório:
        <pre><code>git clone https://github.com/seu-usuario/ApiDesafio.git</code></pre>
    </li>
    <li>Abra o projeto no Visual Studio 2022.</li>
    <li>Compile o projeto para restaurar as dependências.</li>
    <li>Execute o projeto.</li>
</ol>

<h2>Exemplo de Uso</h2>
<p>Para testar a API, você pode usar o arquivo <code>ApiDesafio.http</code> no Visual Studio 2022. Este arquivo contém um exemplo de requisição POST para o endpoint <code>/api/Desafio</code>.</p>

<h2>Dependências</h2>
<ul>
    <li><a href="https://dotnet.microsoft.com/en-us/download/dotnet/8.0">.NET 8</a></li>
    <li>Microsoft.AspNetCore.Mvc</li>
</ul>
<p><strong>Nota:</strong> No texto original, havia um erro mencionando .NET 9, mas o projeto é em .NET 8. Caso o projeto realmente use .NET 9, ajuste a versão correta.</p>

<h2>Logs</h2>
<p>Os logs da sequência correta são gravados no arquivo <code>senha.txt</code> localizado no diretório <code>Senha/</code>.</p>

<h2>Licença</h2>
<p>Este projeto está licenciado sob a <a href="LICENSE">Licença MIT</a>.</p>

<h2>Agradecimentos</h2>
<p>Agradeço novamente à <strong>FIAP</strong> por apoiar o desenvolvimento deste projeto.</p>
