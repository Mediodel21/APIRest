# CURSO XAMARIN - PROYECTO API REST 

Para efectos del proyecto de desarrollo, se utiliza el siguiente API https://jsonplaceholder.typicode.com

# Introducción

Este API permite utilizar información generica de prueba para probar el funcionamiento del consumo del API por medio de REST.

# Desarrollo

La aplicación basicamente realizar el consumo de API por medio de REST para desplegarlo inicialmente en un listView, un listado de con el titulo de una serie de "posts". Desde dicha lista el usuario puede bajar al segundo nivel, constituido por el detalle de los "posts". El tercer nivel de la aplicacion se forma por una lista de usuarios, quienes son responsables de los comentarios hechos a un "posts" espeficico (seleccionado). 

# Ejemplo

fetch('https://jsonplaceholder.typicode.com/todos/1')
  .then(response => response.json())
  .then(json => console.log(json))
  
