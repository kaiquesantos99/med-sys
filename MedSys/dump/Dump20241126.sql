CREATE DATABASE  IF NOT EXISTS `medsys` /*!40100 DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_unicode_ci */ /*!80016 DEFAULT ENCRYPTION='N' */;
USE `medsys`;
-- MySQL dump 10.13  Distrib 8.0.38, for Win64 (x86_64)
--
-- Host: localhost    Database: medsys
-- ------------------------------------------------------
-- Server version	8.3.0

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `detalhes_internacao`
--

DROP TABLE IF EXISTS `detalhes_internacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `detalhes_internacao` (
  `id` int NOT NULL AUTO_INCREMENT,
  `data_atualizacao` datetime DEFAULT CURRENT_TIMESTAMP,
  `detalhes` text,
  `id_internacao` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_internacao` (`id_internacao`),
  CONSTRAINT `detalhes_internacao_ibfk_1` FOREIGN KEY (`id_internacao`) REFERENCES `internacao` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `detalhes_internacao`
--

LOCK TABLES `detalhes_internacao` WRITE;
/*!40000 ALTER TABLE `detalhes_internacao` DISABLE KEYS */;
INSERT INTO `detalhes_internacao` VALUES (1,'2024-11-26 10:24:50','O paciente foi internado.',9);
/*!40000 ALTER TABLE `detalhes_internacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enfermeiro`
--

DROP TABLE IF EXISTS `enfermeiro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enfermeiro` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `dt_admissao` date NOT NULL,
  `matricula` bigint NOT NULL,
  `coren` int NOT NULL,
  `nascimento` date NOT NULL,
  `cpf` char(14) NOT NULL,
  `rg` varchar(10) NOT NULL,
  `pis` int NOT NULL,
  `cep` char(9) NOT NULL,
  `logradouro` varchar(200) NOT NULL,
  `numero` int NOT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `uf` char(2) NOT NULL,
  `telefone` char(16) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `usuario` varchar(100) NOT NULL,
  `senha` varchar(30) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `matricula` (`matricula`),
  UNIQUE KEY `coren` (`coren`),
  UNIQUE KEY `cpf` (`cpf`),
  UNIQUE KEY `rg` (`rg`),
  UNIQUE KEY `pis` (`pis`),
  UNIQUE KEY `usuario` (`usuario`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=14 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfermeiro`
--

LOCK TABLES `enfermeiro` WRITE;
/*!40000 ALTER TABLE `enfermeiro` DISABLE KEYS */;
INSERT INTO `enfermeiro` VALUES (1,'Kaique Dos Santos Costa','2024-11-20',1,425602,'1999-03-05','463.064.678-74','50.072.278',2147483647,'09321-375','Av. Presidente Castelo Branco',2124,'Casa A','Jardim Zaira','Mauá','SP','(11) 9 4252-4330','kaiquesc2013@uni9.edu.br','kaka.01','05031999'),(2,'Carlos Andrade','2015-06-01',10012345678,123456,'1985-09-15','123.456.789-00','12345678',123456789,'12345-678','Rua São Paulo',123,'Apto 12','Centro','São Paulo','SP','(11) 91234-5678','carlos.andrade@hospital.com','carlos.andrade','senha123'),(3,'Maria Fernanda Lima','2018-04-20',10098765432,234567,'1990-03-25','987.654.321-00','98765432',987654321,'54321-987','Avenida Paulista',456,'','Jardins','São Paulo','SP','(11) 98765-4321','maria.lima@hospital.com','maria.lima','senha456'),(4,'João Pedro Silva','2012-09-10',10123456789,345678,'1980-11-11','654.321.987-00','65498712',654321987,'98765-432','Rua das Flores',789,'Bloco A','Industrial','Campinas','SP','(19) 92345-6789','joao.silva@hospital.com','joao.silva','senha789'),(5,'Ana Paula Santos','2020-01-15',10234567891,456789,'1993-02-14','321.654.987-00','32165498',321654987,'32145-678','Travessa Alegre',321,'','Vila Nova','Rio de Janeiro','RJ','(21) 91234-5678','ana.santos@hospital.com','ana.santos','senha321'),(6,'Roberto Almeida','2017-05-30',10345678912,567890,'1987-07-21','456.789.123-00','78912345',456789123,'45612-987','Rua dos Ipês',654,'Casa','Jardim das Acácias','Curitiba','PR','(41) 99876-5432','roberto.almeida@hospital.com','roberto.almeida','senha654'),(7,'Juliana Oliveira','2016-11-22',10456789123,678901,'1995-08-10','987.321.654-00','98765412',987321654,'78912-345','Rua Esperança',987,'','Santa Luzia','Belo Horizonte','MG','(31) 99876-5432','juliana.oliveira@hospital.com','juliana.oliveira','senha987'),(8,'Fernanda Costa','2014-02-28',10567891234,789012,'1988-04-05','654.987.321-00','65432178',654987321,'65498-123','Rua das Palmeiras',123,'','Jardim América','Fortaleza','CE','(85) 91234-5678','fernanda.costa@hospital.com','fernanda.costa','senha852'),(9,'Paulo Henrique Martins','2013-07-10',10678912345,890123,'1985-06-18','789.123.456-00','12378945',789123456,'32165-987','Avenida Brasil',234,'Bloco C','Zona Sul','Porto Alegre','RS','(51) 98765-4321','paulo.martins@hospital.com','paulo.martins','senha963'),(10,'Cláudia Mendes','2019-09-25',10789123456,901234,'1990-01-22','321.987.654-00','32198765',321987654,'98732-154','Rua Nova',456,'','Centro','Salvador','BA','(71) 92345-6789','claudia.mendes@hospital.com','claudia.mendes','senha741'),(11,'Marcelo Farias','2021-03-11',10891234567,112345,'1982-10-30','654.123.789-00','65432198',654123789,'32198-765','Rua São José',789,'','Vila Rica','Recife','PE','(81) 98765-4321','marcelo.farias@hospital.com','marcelo.farias','senha852'),(12,'Irineu Sabino','2024-11-26',234354343,345135,'1985-05-10','984.569.234-74','869380693',951842368,'09321-484','Rua Princesa Isabel',195,'Casa A','Vila Bocain','Mauá','SP','(11) 9 4574-5693','irineusabino@hotmail.com','irineu.101','12345678'),(13,'José Sabino','2024-11-26',435437665,567937,'1973-10-24','093.235.560-74','34869847X',453958685,'09547-549','Rua Coronel Oliveira Lima',495,'Casa A','Centro','Santo André','SP','(11) 9 8495-8933','josesabino@hotmail.com','josesabino.102','12345678');
/*!40000 ALTER TABLE `enfermeiro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `estoque`
--

DROP TABLE IF EXISTS `estoque`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `estoque` (
  `id` int NOT NULL AUTO_INCREMENT,
  `tipo` varchar(100) NOT NULL,
  `medicamento` varchar(200) NOT NULL,
  `quantidade` int NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `estoque`
--

LOCK TABLES `estoque` WRITE;
/*!40000 ALTER TABLE `estoque` DISABLE KEYS */;
INSERT INTO `estoque` VALUES (1,'Dor Muscular','Paracetamol com Codeína',12),(5,'Vacinas','Astrazeneca',29),(8,'Vacinas','Coronavac',30);
/*!40000 ALTER TABLE `estoque` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `internacao`
--

DROP TABLE IF EXISTS `internacao`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `internacao` (
  `id` int NOT NULL AUTO_INCREMENT,
  `id_paciente` int NOT NULL,
  `leito` varchar(10) NOT NULL,
  `setor` varchar(50) NOT NULL,
  `internado_tempo` datetime DEFAULT CURRENT_TIMESTAMP,
  `id_medico` int NOT NULL,
  PRIMARY KEY (`id`),
  KEY `id_medico` (`id_medico`),
  KEY `id_paciente` (`id_paciente`),
  CONSTRAINT `internacao_ibfk_1` FOREIGN KEY (`id_medico`) REFERENCES `medico` (`id`),
  CONSTRAINT `internacao_ibfk_2` FOREIGN KEY (`id_paciente`) REFERENCES `paciente` (`id`)
) ENGINE=InnoDB AUTO_INCREMENT=10 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `internacao`
--

LOCK TABLES `internacao` WRITE;
/*!40000 ALTER TABLE `internacao` DISABLE KEYS */;
INSERT INTO `internacao` VALUES (7,13,'1','UTI','2024-11-26 04:42:08',1),(8,12,'2','UTI','2024-11-26 09:55:26',1),(9,11,'3','UTI','2024-11-26 10:24:50',1);
/*!40000 ALTER TABLE `internacao` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `medico`
--

DROP TABLE IF EXISTS `medico`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `medico` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `dt_admissao` date NOT NULL,
  `matricula` bigint NOT NULL,
  `crm` int NOT NULL,
  `nascimento` date NOT NULL,
  `cpf` char(14) NOT NULL,
  `rg` varchar(10) NOT NULL,
  `pis` int NOT NULL,
  `especialidade` varchar(70) DEFAULT NULL,
  `cep` char(9) NOT NULL,
  `logradouro` varchar(200) NOT NULL,
  `numero` int NOT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `uf` char(2) NOT NULL,
  `telefone` char(16) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `usuario` varchar(100) NOT NULL,
  `senha` varchar(30) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `matricula` (`matricula`),
  UNIQUE KEY `crm` (`crm`),
  UNIQUE KEY `cpf` (`cpf`),
  UNIQUE KEY `rg` (`rg`),
  UNIQUE KEY `pis` (`pis`),
  UNIQUE KEY `usuario` (`usuario`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `medico`
--

LOCK TABLES `medico` WRITE;
/*!40000 ALTER TABLE `medico` DISABLE KEYS */;
INSERT INTO `medico` VALUES (1,'Ana Carolina Lisboa de Oliveira','2024-11-20',1,206524,'2004-08-04','851.356.150-91','3116424957',2147483647,'Neurologista','06447-530','Rua Onix',331,'Casa 1','Jardim Paulista','Barueri','SP','(11) 9 7827-5802','carol.aclo@uni9.edu.br','carol.01','04082004');
/*!40000 ALTER TABLE `medico` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `paciente`
--

DROP TABLE IF EXISTS `paciente`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `paciente` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `nascimento` date NOT NULL,
  `cpf` char(14) NOT NULL,
  `rg` varchar(10) NOT NULL,
  `cep` char(9) NOT NULL,
  `logradouro` varchar(200) NOT NULL,
  `numero` int NOT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `uf` char(2) NOT NULL,
  `telefone` char(16) NOT NULL,
  `telefone_2` char(16) DEFAULT NULL,
  `acompanhante` varchar(200) DEFAULT NULL,
  `carteirinha` char(23) NOT NULL,
  `convenio` varchar(50) NOT NULL,
  `peso` decimal(5,2) NOT NULL,
  `altura` decimal(3,2) NOT NULL,
  `observacoes` text,
  `status_paciente` varchar(50) NOT NULL DEFAULT 'aguardando',
  `sexo` varchar(50) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `cpf` (`cpf`),
  UNIQUE KEY `rg` (`rg`),
  UNIQUE KEY `carteirinha` (`carteirinha`)
) ENGINE=InnoDB AUTO_INCREMENT=17 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `paciente`
--

LOCK TABLES `paciente` WRITE;
/*!40000 ALTER TABLE `paciente` DISABLE KEYS */;
INSERT INTO `paciente` VALUES (1,'Vinicius Santos','1994-05-10','516.489.254-34','849377592','09834-954','Rua Coronel Oliveira Lima',214,'Comércio','Centro','Santo André','SP','(11) 9 8458-8945','(11) 9 8458-8945',NULL,'15462356784123468495452','Notredame Intermedica',75.20,1.74,'Alergia a paracetamol','aguardando','Masculino'),(2,'Osvaldo','2001-10-24','234.845.932-45','58495969X','09546-213','Rua Coronel Oliveira Lima',34,'Casa A','Centro','Santo André','SP','(11) 9 5456-2436','',NULL,'12154545465456465456465','Amil',64.80,1.66,'Sem alergias','aguardando','Masculino'),(5,'Manoela Tavares','2000-10-10','234.346.213-54','86349594X','09247-854','Rua Princesa Isabel',23,'Casa A','Vila Bocaina','Mauá','SP','(11) 9 8549-4394','',NULL,'38459385942809825099850','Intermedica',67.40,1.92,'Alergia a amoxicilina','aguardando','Feminino'),(6,'João Silva','1990-05-14','123.456.789-00','12345678','12345-678','Rua das Flores',123,'Apto 12','Centro','São Paulo','SP','(11) 91234-5678','(11) 92345-6789','Maria Silva','12345678901234567890123','Amil',78.50,1.75,'Paciente com alergia a penicilina.','aguardando','Masculino'),(7,'Maria Souza','1985-09-22','987.654.321-00','87654321','98765-432','Avenida Paulista',456,'Casa','Jardins','São Paulo','SP','(11) 98765-4321','(11) 97654-3210','José Souza','98765432109876543210987','Bradesco Saúde',65.40,1.62,'Paciente com hipertensão.','aguardando','Feminino'),(8,'Carlos Pereira','1978-11-03','654.321.987-00','65498712','54321-987','Rua do Comércio',789,'Sala 5','Industrial','Campinas','SP','(19) 91234-5678','(19) 92345-6789','Ana Pereira','65432198765432198765432','SulAmérica',82.30,1.80,'Histórico de diabetes.','aguardando','Masculino'),(9,'Ana Paula Santos','1995-02-18','321.654.987-00','32165498','12365-789','Travessa Alegre',321,'Bloco B','Vila Nova','Rio de Janeiro','RJ','(21) 91234-5678','(21) 97654-3210','Paulo Santos','32165498732165498732165','Unimed',59.80,1.68,'','alta','Feminino'),(10,'Roberto Gomes','1982-07-09','456.789.123-00','78912345','45612-987','Rua dos Ipês',654,'','Jardim das Acácias','Curitiba','PR','(41) 99876-5432','(41) 92345-6789','','45678912345678912345678','Golden Cross',92.60,1.85,'Paciente sem acompanhante.','aguardando','Masculino'),(11,'Juliana Oliveira','2000-12-25','987.321.654-00','98765412','32145-678','Rua Esperança',987,'','Santa Luzia','Belo Horizonte','MG','(31) 99876-5432','(31) 98765-4321','Carlos Oliveira','98732165498732165498732','Amil',55.70,1.60,'Paciente com acompanhamento.','Internado','Feminino'),(12,'Paulo Henrique Costa','1988-04-15','654.987.321-00','65432178','65498-123','Rua das Palmeiras',123,'Casa','Jardim América','Fortaleza','CE','(85) 91234-5678','(85) 92345-6789','Fernanda Costa','65498732165498732165498','Hapvida',76.50,1.78,'','Internado','Masculino'),(13,'Fernanda Lima','1993-03-12','789.123.456-00','12378945','78912-345','Avenida Brasil',234,'','Zona Sul','Porto Alegre','RS','(51) 98765-4321','(51) 92345-6789','Rodrigo Lima','78912345678912345678912','Bradesco Saúde',63.20,1.70,'','Internado','Feminino'),(14,'Marcelo Farias','1975-08-07','321.987.654-00','32198765','98732-154','Rua Nova',456,'Sala 2','Centro','Salvador','BA','(71) 91234-5678','(71) 92345-6789','Clara Farias','32198765432198765432198','SulAmérica',88.70,1.76,'Paciente com insuficiência cardíaca.','alta','Masculino'),(15,'Cláudia Mendes','1991-10-30','654.123.789-00','65432198','32198-765','Rua São José',789,'','Vila Rica','Recife','PE','(81) 98765-4321','(81) 92345-6789','','65412378965412378965412','Unimed',68.40,1.65,'','aguardando','Feminino'),(16,'Maria Dolores','1967-04-01','563.340.459-34','45849375X','09325-945','Av. Presidente Castelo Branco',2124,'Casa B','Jardim Zaira','Mauá','SP','(11) 9 4589-4584','(11) 9 5476-3485',NULL,'45943853985395395893589','Notredame Intermédica',96.60,1.66,'Alergia a dipirona.','aguardando','Feminino');
/*!40000 ALTER TABLE `paciente` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `recepcionista`
--

DROP TABLE IF EXISTS `recepcionista`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `recepcionista` (
  `id` int NOT NULL AUTO_INCREMENT,
  `nome` varchar(200) NOT NULL,
  `dt_admissao` date NOT NULL,
  `matricula` bigint NOT NULL,
  `nascimento` date NOT NULL,
  `cpf` char(14) NOT NULL,
  `rg` varchar(10) NOT NULL,
  `pis` int NOT NULL,
  `cep` char(9) NOT NULL,
  `logradouro` varchar(200) NOT NULL,
  `numero` int NOT NULL,
  `complemento` varchar(100) DEFAULT NULL,
  `bairro` varchar(100) NOT NULL,
  `cidade` varchar(100) NOT NULL,
  `uf` char(2) NOT NULL,
  `telefone` char(16) NOT NULL,
  `email` varchar(100) DEFAULT NULL,
  `usuario` varchar(100) NOT NULL,
  `senha` varchar(30) NOT NULL,
  PRIMARY KEY (`id`),
  UNIQUE KEY `matricula` (`matricula`),
  UNIQUE KEY `cpf` (`cpf`),
  UNIQUE KEY `rg` (`rg`),
  UNIQUE KEY `pis` (`pis`),
  UNIQUE KEY `usuario` (`usuario`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=3 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recepcionista`
--

LOCK TABLES `recepcionista` WRITE;
/*!40000 ALTER TABLE `recepcionista` DISABLE KEYS */;
INSERT INTO `recepcionista` VALUES (1,'Allan Victor Pehlivanidis','2024-11-20',1,'1999-11-24','191.009.011-57','84.859.219',2147483647,'06230-171','Cracolândia',244,'Casa B','Santa Ifigênia','São Paulo','SP','(57) 9 1571-7124','allan.victor.dev@gmail.com','allan.01','12345678'),(2,'Josiel Brito','2024-11-23',2,'1991-05-10','456.986.954-46','580299603',1234568301,'09345-456','Rua Coronel Oliveira Lima',112,'Comércio','Centro','Santo André','SP','(11) 9 5860-5835','josielbrito@uni9.edu.br','josiel.02','12345678');
/*!40000 ALTER TABLE `recepcionista` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2024-11-26 16:25:25
