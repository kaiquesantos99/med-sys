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
  UNIQUE KEY `senha` (`senha`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfermeiro`
--

LOCK TABLES `enfermeiro` WRITE;
/*!40000 ALTER TABLE `enfermeiro` DISABLE KEYS */;
INSERT INTO `enfermeiro` VALUES (1,'Kaique Dos Santos Costa','2024-11-20',1,425602,'1999-03-05','463.064.678-74','50.072.278',2147483647,'09321-375','Av. Presidente Castelo Branco',2124,'Casa A','Jardim Zaira','Mauá','SP','(11) 9 4252-4330','kaiquesc2013@uni9.edu.br','kaka.01','05031999');
/*!40000 ALTER TABLE `enfermeiro` ENABLE KEYS */;
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
  UNIQUE KEY `senha` (`senha`),
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
  UNIQUE KEY `senha` (`senha`),
  UNIQUE KEY `email` (`email`)
) ENGINE=InnoDB AUTO_INCREMENT=2 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `recepcionista`
--

LOCK TABLES `recepcionista` WRITE;
/*!40000 ALTER TABLE `recepcionista` DISABLE KEYS */;
INSERT INTO `recepcionista` VALUES (1,'Allan Victor Pehlivanidis','2024-11-20',1,'1999-11-24','191.009.011-57','84.859.219',2147483647,'06230-171','Cracolândia',244,'Casa B','Santa Ifigênia','São Paulo','SP','(57) 9 1571-7124','allan.victor.dev@gmail.com','allan.01','12345678');
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

-- Dump completed on 2024-11-21  0:57:42
