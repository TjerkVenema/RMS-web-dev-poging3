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
  `user_id` int DEFAULT NULL,
  `artist` varchar(45) DEFAULT NULL,
  `title` varchar(45) DEFAULT NULL,
  `label` varchar(45) DEFAULT NULL,
  `format` varchar(45) DEFAULT NULL,
  `rating` varchar(5) DEFAULT NULL,
  `releasedate` date DEFAULT NULL,
  `dateadded` date DEFAULT NULL,
  `collection` varchar(45) DEFAULT NULL,
  `notes` varchar(45) DEFAULT NULL,
  `for_sale` tinyint NOT NULL DEFAULT '0',
  PRIMARY KEY (`record_id`),
  KEY `owner_fk_idx` (`user_id`),
  CONSTRAINT `owner_fk` FOREIGN KEY (`user_id`) REFERENCES `user` (`user_id`)
) ENGINE=InnoDB AUTO_INCREMENT=15 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `record`
--

LOCK TABLES `record` WRITE;
/*!40000 ALTER TABLE `record` DISABLE KEYS */;
INSERT INTO `record` VALUES (1,3,'David Bowie','Heroes',NULL,'CD',NULL,NULL,NULL,NULL,NULL,0),(2,2,'Elton John','Your Song',NULL,'LP',NULL,NULL,NULL,NULL,NULL,1),(3,4,'Bob Marley','Three Little Birds','Tuff_Gong','LP',NULL,'1977-03-22','2021-03-22','Exodus','PrachtigePlaat',0),(4,5,'Bob Marley','Three Little Birds','Tuff_Gong','LP',NULL,'1977-03-22','2021-03-22','Exodus','Prachtige_Plaat',1),(5,3,'Bob Marley','Three Little Birds','Tuff_Gong','LP',NULL,'1977-03-22','2021-03-22','Exodus','Prachtige_Plaat',0),(6,2,'Bob Marley','Three Little Birds','Tuff_Gong','LP',NULL,'1977-03-22','2021-03-22','Exodus','Prachtige_Plaat',0),(7,7,'hoi','hoi','hoi',NULL,NULL,NULL,NULL,NULL,'hoi',0),(8,7,'hoi','hoi','hoi',NULL,NULL,NULL,NULL,NULL,'hoi',0),(9,NULL,'hoi','hoi','hoi',NULL,NULL,NULL,NULL,NULL,'hoi',0),(10,7,'hoi','hoi','hoi',NULL,NULL,NULL,NULL,NULL,'hoi',0),(11,7,'hallo','hallo','hallo',NULL,NULL,NULL,NULL,NULL,'hallo',0),(12,7,'hallo','hallo','hallo',NULL,NULL,NULL,NULL,NULL,'hallo',0),(13,11,'poah','poah','poah',NULL,NULL,NULL,NULL,NULL,'poah',0),(14,7,'hoi','hoi','hoi',NULL,NULL,NULL,NULL,NULL,'hoi',0);
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

-- Dump completed on 2021-04-01 11:10:08
