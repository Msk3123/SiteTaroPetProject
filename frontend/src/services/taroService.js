const createCartTaro = async (data) => {
    try {
        console.log('🚀 Відправляємо запит на:', '/api/CartTaro');
        console.log('📦 Дані для відправки:', data);

        const response = await fetch('/api/CartTaro', {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
        });

        console.log('📡 Статус відповіді:', response.status);
        console.log('📡 Content-Type:', response.headers.get('content-type'));

        if(!response.ok) {
            const responseText = await response.text();
            console.error('❌ Помилка відповідь:', responseText);

            // Пробуємо парсити як JSON, якщо не вийде - повертаємо текст
            try {
                const errorData = JSON.parse(responseText);
                throw new Error(errorData.error || errorData.message || `HTTP Error: ${response.status}`);
            } catch (parseError) {
                throw new Error(`HTTP Error ${response.status}: ${responseText}`);
            }
        }

        const result = await response.json();
        console.log('✅ Успішна відповідь:', result);
        return result;

    } catch (error) {
        console.error('💥 API помилка:', error);
        throw error;
    }
};
