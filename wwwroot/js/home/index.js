

function hola() {
  console.log("hola")

}

getUser1 = () => {
  axios.get("https://jsonplaceholder.typicode.com/users/1").then(r => {
    console.log(r.data)
  })
}

fillTable = () => {
  let tbodyTable = document.getElementById('tbodyTable')
  tbodyTable.innerHTML = ''
  // axios.get("https://jsonplaceholder.typicode.com/users").then(r => {
  //   r.data.forEach(element => {
  //     let tr = document.createElement('tr')
  //     tr.insertAdjacentHTML('beforeend', '<td>'+ element.id+'</td>')
  //     tr.insertAdjacentHTML('beforeend', '<td>'+ element.name+'</td>')
  //     tbodyTable.appendChild(tr)
  //   });
  // })
  fetch('https://jsonplaceholder.typicode.com/users').then(r=>r.json()).then(data => {
    data.forEach(element => {
      let tr = document.createElement('tr')
      tr.insertAdjacentHTML('beforeend', '<td>'+ element.id+'</td>')
      tr.insertAdjacentHTML('beforeend', '<td>'+ element.name+'</td>')
      tbodyTable.appendChild(tr)
    });
  })
}

obtenerInformacionTabla = () => {
  let tabla = document.getElementById('tabla')
  console.log(tabla.childNodes)
  console.log(tabla.children)
  console.log(tabla.getElementsByTagName('tbody')[0])
}

deleteTable = () => {
  let divTabla = document.getElementById('tabla')
  divTabla.innerHTML = ''
}

fillTablePartial = () => {
  fetch('/Home/Tabla').then(r => r.text()).then(data => {
    console.log(data)
  })
  // axios.get("https://localhost:5001/Home/Tabla").then(r => {
  //   console.log(r.data)
  // })
}
