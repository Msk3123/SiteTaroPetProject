import { useState } from 'react';
import { createCartTaro } from '../services/taroService';

export const useTaroForm = () => {
    const [formData, setFormData] = useState({
        Name: '',              
        UprightMeaning: '',
        ReversedMeaning: '',
        Keywords: ''
    });
    const [errors, setErrors] = useState({});
    const [isLoading, setIsLoading] = useState(false);
    const [message, setMessage] = useState("");

    const handleChange = (e) => {
        setFormData({
            ...formData,
            [e.target.name]: e.target.value
        });
        if (errors[e.target.name]) {
            setErrors({
                ...errors,
                [e.target.name]: ''
            });
        }
    };
    const validateForm = () => {
        const newErrors = {};

        if (!formData.Name.trim()) {
            newErrors.Name = 'Назва карти обов\'язкова';
        }

        if (!formData.UprightMeaning.trim()) {
            newErrors.UprightMeaning = 'Пряме значення обов\'язкове';
        }

        setErrors(newErrors);
        return Object.keys(newErrors).length === 0;
    };

    const handleSubmit = async (e) => {
        e.preventDefault();

        if (!validateForm()) {
            return;
        }

        setIsLoading(true);
        setMessage("Cтворення карти...");

        try {
            await createCartTaro(formData);
            setMessage('Карта Таро успішно створена!');
            setFormData({
                Name: '',
                UprightMeaning: '',
                ReversedMeaning: '',
                Keywords: ''
            });
            setErrors({});
        }
        catch (error) {
            setMessage(`Помилка: ${error.message}`);
        }
        finally {
            setIsLoading(false);
        }
    };
    return {
        formData,
        errors,
        isLoading,
        message,
        handleChange,
        handleSubmit
    };
}