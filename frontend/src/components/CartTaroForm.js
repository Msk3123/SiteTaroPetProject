import React from 'react';
import { useTaroForm } from '../hooks/useTaroForm';
import './CartTaroForm.css';

const CartTaroForm = () => {
    const { formData, errors, isLoading, message, handleChange, handleSubmit } = useTaroForm();

    return (
        <div className="cart-taro-form-container">
            <h2>Створити нову карту Таро</h2>
            <form onSubmit={handleSubmit} className="cart-taro-form">
                <div className="form-group">
                    <label htmlFor="Name">Назва карти *</label>
                    <input
                        type="text"
                        id="Name"
                        name="Name"
                        value={formData.Name}
                        onChange={handleChange}
                        placeholder="Наприклад: Шут, Маг, Верховна Жриця"
                        disabled={isLoading}
                    />
                    {errors.Name && <span className="error">{errors.Name}</span>}
                </div>

                <div className="form-group">
                    <label htmlFor="UprightMeaning">Пряме значення *</label>
                    <textarea
                        id="UprightMeaning"
                        name="UprightMeaning"
                        value={formData.UprightMeaning}
                        onChange={handleChange}
                        placeholder="Опишіть значення карти у прямому положенні"
                        rows="4"
                        disabled={isLoading}
                    />
                    {errors.UprightMeaning && <span className="error">{errors.UprightMeaning}</span>}
                </div>

                <div className="form-group">
                    <label htmlFor="ReversedMeaning">Перевернуте значення</label>
                    <textarea
                        id="ReversedMeaning"
                        name="ReversedMeaning"
                        value={formData.ReversedMeaning}
                        onChange={handleChange}
                        placeholder="Опишіть значення карти у перевернутому положенні"
                        rows="4"
                        disabled={isLoading}
                    />
                    {errors.ReversedMeaning && <span className="error">{errors.ReversedMeaning}</span>}
                </div>

                <div className="form-group">
                    <label htmlFor="Keywords">Ключові слова</label>
                    <input
                        type="text"
                        id="Keywords"
                        name="Keywords"
                        value={formData.Keywords}
                        onChange={handleChange}
                        placeholder="Наприклад: початок, спонтанність, невинність"
                        disabled={isLoading}
                    />
                    {errors.Keywords && <span className="error">{errors.Keywords}</span>}
                </div>

                <button type="submit" disabled={isLoading} className="submit-button">
                    {isLoading ? 'Створення...' : 'Створити карту'}
                </button>

                {message && (
                    <div className={`message ${message.includes('✅') ? 'success' : 'error'}`}>
                        {message}
                    </div>
                )}
            </form>
        </div>
    );
};

export default CartTaroForm;
