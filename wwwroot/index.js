const iniciar = async () => {
    const mensagem = document.getElementById('mensagem');
    const response = await fetch('/quemsoueuapi');
    const result = await response.json();
    mensagem.innerHTML = `Meu nome é ${result.mensagem}. Me siga no GitHub: <a href="${result.url}">${result.mensagem1}</a>.`;
};

document.addEventListener('DOMContentLoaded', iniciar);
