Algoritmo Lecc16Inc1
	Dimensionar edadesPersonas[7]
	Definir indice, Mayores Como Entero
	
	Mayores = 0
	Para indice = 1 Hasta 7 Hacer
		Escribir "Ingrese la edad de la persona ", indice , ": "
		Leer edadesPersonas[indice]
		Si edadesPersonas[indice] >= 18 Entonces
			Mayores = Mayores + 1
		Fin Si
	Fin Para
	
	Escribir "La cantidad de personas mayores es: ", Mayores
FinAlgoritmo