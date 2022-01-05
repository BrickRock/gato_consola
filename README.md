# gato_consola
Pequeño proyecto hecho en c#, del juego del gato.

lo siguiente no tengo ni idea de que es y creo que no deberia estar en este repositorio

	bin/
	obj/
	programa01.csproj

Se que son archivos necesario para que .Net funcione pero poco mas

El gato solo es de un jugador contra la "ia", que realmente lo único que hace es seleccionar una casilla al azar dentre las que estan vacias

 > la "ia" solo hace una selección al azar de las casillas disponibles

#Estructura del proyecto

EL proyecto cuenta con la siguiente organización

	Program.cs
	tablero.cs
	validar.cs

	jugadores/
			jugador.cs

	validacion/
			centro.cs
			combinaciones.cs
			ganador.cs
			CentrosL.cs
			ESquinas.cs


Realmente todo lo que esta dentro de la carpeta validacion no era necesario pero quize conplicarme la vida evitando hacer un if que validara todos los posibles escenarios ganadores

En vez de eso esta toda la moustrocidad dentro de la carpeta validacion

