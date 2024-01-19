DECLARE @discipline			SMALLINT	= (SELECT discipline_id FROM Disciplines WHERE discipline_name LIKE 'UML и паттерны проектирования')
DECLARE @teacher			INT			= (SELECT teacher_id FROM Teachers WHERE last_name LIKE 'Покидюк' AND first_name LIKE 'Марина' AND middle_name LIKE 'Олеговна')
DECLARE @start_date			DATE		= '2024-01-01'
DECLARE @date				DATE		= @start_date
DECLARE @time				TIME		= '18:30'
DECLARE @group				INT			= (SELECT group_id FROM Groups WHERE group_name LIKE '%PV_211%')
DECLARE @number_of_lessons	TINYINT		= (SELECT number_of_lessons FROM Disciplines WHERE discipline_id = @discipline)
DECLARE @counter			INT			= 0

WHILE(@counter < @number_of_lessons)
BEGIN

	INSERT INTO Schedule(discipline, techer, [date], [time], spent, [group] )
	VALUES				(@discipline, @teacher, @date, @time, IIF(@date < GETDATE(),  1, 0), @group);
	SET @counter = @counter + 1;

	IF  (@counter % 2 = 0 )
		SET @date = IIF(DATEPART (dw, @date) = 6,  DATEADD(dd, 3, @date), DATEADD(dd, 2, @date))
	SET @time = IIF(@time='18:30', DATEADD(mi, 90, CONVERT(TIME, @time)), '18:30')	

END;