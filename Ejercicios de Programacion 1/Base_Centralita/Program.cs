USE Base_Centralita;

CREATE TABLE Llamadas (
    Id INT PRIMARY KEY IDENTITY(1,1),
    NumeroOrigen VARCHAR(20) NOT NULL,
    NumeroDestino VARCHAR(20) NOT NULL,
    Duracion INT NOT NULL,
    Costo DECIMAL(10,2) NOT NULL
);
