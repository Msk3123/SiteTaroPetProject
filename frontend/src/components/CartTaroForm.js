import { useTaroForm } from '../hooks/useTaroForm'; // Імпортуємо наш хук
import './CartTaroForm.css';

const CartTaroForm = () => {
    // Вся логіка приходить звідси, компонент нічого не обчислює сам
    const {
        formData,
        errors,
        isLoading,
        message,
        handleChange,
        handleSubmit
    } = useTaroForm();

    // JSX використовує отримані дані та функції для відображення
    return (
        <div className="cart-taro-form-container">
            <h2>Створити карту Таро</h2>

            {/* 1. Використовуємо `message` для відображення повідомлень */}
            {message && (
                <div className={message.includes('✅') ? 'message success' : 'message error'}>
                    {message}
                </div>
            )}

            {/* 2. `handleSubmit` прив'язується до форми */}
            <form onSubmit={handleSubmit} className="cart-taro-form">
                <div className="form-group">
                    <label htmlFor="Name">Назва карти *</label>
                    <input
                        type="text"
                        id="Name"
                        name="Name"
                        value={formData.Name}
                        onChange={handleChange}
                        placeholder="Наприклад: Маг, Дурень, Імператриця"
                        className={errors.Name ? 'error' : ''}
                    />
                    {errors.Name && <span className="error-message">{errors.Name}</span>}
                </div>

                <div className="form-group">
                    <label htmlFor="UprightMeaning">Пряме значення *</label>
                    <textarea
                        id="UprightMeaning"
                        name="UprightMeaning"
                        value={formData.UprightMeaning}
                        onChange={handleChange}
                        placeholder="Опишіть пряме значення карти"
                        rows="4"
                        className={errors.UprightMeaning ? 'error' : ''}
                    />
                    {errors.UprightMeaning && <span className="error-message">{errors.UprightMeaning}</span>}
                </div>

                <div className="form-group">
                    <label htmlFor="ReversedMeaning">Перевернене значення</label>
                    <textarea
                        id="ReversedMeaning"
                        name="ReversedMeaning"
                        value={formData.ReversedMeaning}
                        onChange={handleChange}
                        placeholder="Опишіть перевернене значення карти"
                        rows="4"
                    />
                </div>

                <div className="form-group">
                    <label htmlFor="Keywords">Ключові слова</label>
                    <input
                        type="text"
                        id="Keywords"
                        name="Keywords"
                        value={formData.Keywords}
                        onChange={handleChange}
                        placeholder="любов, магія, початок"
                    />
                </div>

                {/* 6. `isLoading` використовується для керування станом кнопки */}
                <button type="submit" disabled={isLoading} className="submit-button">
                    {isLoading ? '⏳ Створення...' : '✨ Створити карту'}
                </button>
            </form>
        </div>
    );
};

export default CartTaroForm;