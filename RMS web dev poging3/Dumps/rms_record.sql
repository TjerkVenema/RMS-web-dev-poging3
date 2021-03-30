-- MySQL dump 10.13  Distrib 8.0.23, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: rms
-- ------------------------------------------------------
-- Server version	8.0.23

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
-- Table structure for table `record`
--

DROP TABLE IF EXISTS `record`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `record` (
  `record_id` int NOT NULL AUTO_INCREMENT,
  `owner` int DEFAULT NULL,
  `artist` varchar(45) DEFAULT NULL,
  `title` varchar(45) DEFAULT NULL,
  `label` varchar(45) DEFAULT NULL,
  `format` varchar(45) DEFAULT NULL,
  `rating` char(1) DEFAULT NULL,
  `releasedate` date DEFAULT NULL,
  `dateadded` date DEFAULT NULL,
  `collection` varchar(45) DEFAULT NULL,
  `notes` varchar(45) DEFAULT NULL,
  PRIMARY KEY (`record_id`),
  KEY `owner_fk_idx` (`owner`),
  CONSTRAINT `owner_fk` FOREIGN KEY (`owner`) REFERENCES `user` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `record`
--

LOCK TABLES `record` WRITE;
/*!40000 ALTER TABLE `record` DISABLE KEYS */;
INSERT INTO `record` VALUES (1,3,'david bowie','Heroes',NULL,'CD','9',NULL,NULL,NULL,NULL),(2,2,'elton john','elton john',NULL,'LP','9',NULL,NULL,NULL,NULL),(3,4,'Bob_Marley','Three Little Birds','Tuff_Gong','LP','8','1977-03-22','2021-03-22','Exodus','PrachtigePlaat'),(4,5,'Bob_Marley','Three Little Birds','Tuff_Gong','LP','8','1977-03-22','2021-03-22','Exodus','Prachtige_Plaat'),(5,3,'Bob_Marley','Three Little Birds','Tuff_Gong','LP','8','1977-03-22','2021-03-22','Exodus','Prachtige_Plaat'),(6,2,'Bob_Marley','Three LittleBirds','Tuff_Gong','LP','8','1977-03-22','2021-03-22','Exodus','Prachtige_Plaat');
/*!40000 ALTER TABLE `record` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-30 12:02:27
