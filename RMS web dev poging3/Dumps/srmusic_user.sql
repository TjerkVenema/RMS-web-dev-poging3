DROP TABLE IF EXISTS `user`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `user` (
                        `user_id` int NOT NULL AUTO_INCREMENT,
                        `firstname` varchar(45) DEFAULT NULL,
                        `lastname` varchar(45) DEFAULT NULL,
                        `emailadres` varchar(45) DEFAULT NULL,
                        `password` varchar(45) DEFAULT NULL,
                        `adres` varchar(45) DEFAULT NULL,
                        `city` varchar(45) DEFAULT NULL,
                        `zipcode` char(6) DEFAULT NULL,
                        `country` varchar(45) DEFAULT NULL,
                        PRIMARY KEY (`user_id`),
                        UNIQUE KEY `emailadres_UNIQUE` (`emailadres`)
) ENGINE=InnoDB AUTO_INCREMENT=9 DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_0900_ai_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `user`
--

LOCK TABLES `user` WRITE;
/*!40000 ALTER TABLE `user` DISABLE KEYS */;
INSERT INTO `user` VALUES (2,'Samuel','Jansen','hutjemutje@gmail.com','testing123','legedyk 68','wirdum','9088AC','Wirdum'),(3,'Samuel','Jansen','hoi@gmail.com','testing123','legedyk 68','wirdum','9088AC','Wirdum'),(4,'Samuel','Jansen','poah@gmail.com','testing123','legedyk 68','wirdum','9088AC','Wirdum'),(5,'Samuel','Jansen','hallo@gmail.com','testing123','legedyk 68','wirdum','9088AC','Wirdum'),(6,'Tjerk','Venema','goeie@hoi.com','test12345',NULL,NULL,NULL,NULL),(7,NULL,NULL,'hoi@hoi.com','hoi',NULL,NULL,NULL,NULL),(8,NULL,NULL,'2@3','Test12345',NULL,NULL,NULL,NULL);
/*!40000 ALTER TABLE `user` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2021-03-29 16:30:24
