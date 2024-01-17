SELECT	
		[Имя] = Criminals.first_name, 
		[Фамилия] = Criminals.last_name, 
		[Дата рождения] = Criminals.birtg_day, 
		[Номер машины] = Criminals.number_car, 
		[Город] = Crime_place.city, 
		[Улица] = Crime_place.street, 
		[Номер дома] = Crime_place.number_house, 
		[Нарушение] = Article.article_text, 
		[Дата] = Crimes.[date]
FROM	Crimes, Criminals, Crime_place, Article
WHERE	Crimes.criminal_id = Criminals.id
AND		Crimes.criminal_place_id = Crime_place.id
AND		Crimes.article_id = Article.id