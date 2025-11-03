const API_BASE_URL = 'https://localhost:7240/api';

export const createCartTaro = async (data) => {
    try {
        const response = await fetch(`${API_BASE_URL}/CartTaro`, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json',
            },
            body: JSON.stringify(data),
        });

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const result = await response.text();
        return result;
    } catch (error) {
        console.error('Error creating CartTaro:', error);
        throw error;
    }
};

export const getAllCartTaro = async () => {
    try {
        const response = await fetch(`${API_BASE_URL}/CartTaro`);

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const data = await response.json();
        return data;
    } catch (error) {
        console.error('Error fetching CartTaro:', error);
        throw error;
    }
};

export const getCartTaroById = async (id) => {
    try {
        const response = await fetch(`${API_BASE_URL}/CartTaro/${id}`);

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        const data = await response.json();
        return data;
    } catch (error) {
        console.error('Error fetching CartTaro by ID:', error);
        throw error;
    }
};

export const deleteCartTaro = async (id) => {
    try {
        const response = await fetch(`${API_BASE_URL}/CartTaro/${id}`, {
            method: 'DELETE',
        });

        if (!response.ok) {
            throw new Error(`HTTP error! status: ${response.status}`);
        }

        return true;
    } catch (error) {
        console.error('Error deleting CartTaro:', error);
        throw error;
    }
};
