# CURSO XAMARIN - PROYECTO API REST 

Para efectos del proyecto de desarrollo, se utiliza el siguiente API https://jsonplaceholder.typicode.com

# Introducción

Este API permite utilizar la información generica (datos de prueba), para corroborar el funcionamiento del consumo del API por medio de REST.

# Desarrollo

La aplicación basicamente realiza el consumo de API por medio de REST, con el objetivo de desplegar el titulo de una serie de "posts"  en un control tipo listView. Desde dicha lista, el usuario puede bajar al segundo nivel, constituido por el detalle de los "posts". El tercer nivel de la aplicación, se forma por una lista de usuarios, quienes son responsables de los comentarios hechos a un "posts" espeficico (seleccionado). 

# Ejemplo

fetch('https://jsonplaceholder.typicode.com/todos/1')
  .then(response => response.json())
  .then(json => console.log(json))
  
