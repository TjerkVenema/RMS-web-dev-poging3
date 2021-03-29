

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
  `price` int DEFAULT NULL,
  PRIMARY KEY (`record_id`)
) ENGINE=InnoDB AUTO_INCREMENT=7 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `record`
--

LOCK TABLES `record` WRITE;
/*!40000 ALTER TABLE `record` DISABLE KEYS */;
INSERT INTO `record` VALUES (1,3,'david bowie','Heroes',NULL,'CD','9',NULL,NULL,NULL,NULL,50),(2,2,'elton john','elton john',NULL,'LP','9',NULL,NULL,NULL,NULL,40),(3,4,'Bob_Marley','Three Little Birds','Tuff_Gong','LP','8','1977-03-22','2021-03-22','Exodus','PrachtigePlaat',35),(4,5,'Bob_Marley','Three Little Birds','Tuff_Gong','LP','8','1977-03-22','2021-03-22','Exodus','Prachtige_Plaat',30),(5,3,'Bob_Marley','Three Little Birds','Tuff_Gong','LP','8','1977-03-22','2021-03-22','Exodus','Prachtige_Plaat',35),(6,2,'Bob_Marley','Three LittleBirds','Tuff_Gong','LP','8','1977-03-22','2021-03-22','Exodus','Prachtige_Plaat',35);
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

-- Dump completed on 2021-03-29 13:23:46
