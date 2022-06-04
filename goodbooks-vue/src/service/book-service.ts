import axios from 'axios';
import IBook from '@/types/Book';

export default class BookService {

    API_URL = process.env.VUE_APP_API_URL;
    
    public async getAllBooks(): Promise<IBook> {
        let result = await axios.get(`${this.API_URL}/books/`)
        return result.data;
    }
}