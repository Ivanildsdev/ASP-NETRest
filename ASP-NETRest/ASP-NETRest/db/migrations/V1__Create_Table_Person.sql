CREATE TABLE IF NOT EXISTS `person` (
`id` bigint(20) NOT NULL AUTO_INCREMENT,
`first_name` varchar(80) NOT NULL,
`LAST_name` varchar(80) NOT NULL,
`address` varchar(80) NOT NULL,
`gender` varchar(80) NOT NULL,
PRIMARY KEY (`id`)
)