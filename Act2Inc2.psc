Algoritmo Act2Inc2
	Dimensionar numerosEnteros[8]
	Definir indice, nMayor, pMayor Como Entero
	
	Para indice=1 Hasta 8 Hacer
		Escribir "Ingrese el numero: ", indice, ": "
		Leer numerosEnteros[indice]
		
		Si indice=1 Entonces
			nMayor = numerosEnteros[indice]
			pMayor=indice
		SiNo
			Si numerosEnteros[indice] > nMayor Entonces
				nMayor = numerosEnteros[indice]
				pMayor=indice
			Fin Si
		Fin Si
	Fin Para
	
	Escribir "El numero mayor es: ", nMayor
	Escribir "Esta en la posicion: ", pMayor
FinAlgoritmo