const iniciar = async () => {
  const mensagem = document.getElementById('burguers');
  const response = await fetch('/hamburgueria');
  const result = await response.json();
  result.forEach(burguer => mensagem.insertAdjacentHTML('beforeend', `<li>${burguer.nome} - ${burguer.preco}</li>`));
};

document.addEventListener('DOMContentLoaded', iniciar);