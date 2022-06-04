<script lang="ts">

  import {Options, Vue} from 'vue-class-component';
  import IBook from "@/types/Book";
  import BookService from '@/service/book-service';
  import Book from "@/components/Book.vue";

  const bookService = new BookService();

  @Options({
    name: 'MyBooks',
    components: { Book }
  })
  export default class MyBooks extends Vue {

    // data
    myBooks: IBook[] = [];
    
    // computed properties
    get bookCount() {
      return this.myBooks.length;
    }
    
    // props
    

    // methods
    
    // lifecycle hooks
    created() {
      bookService.getAllBooks()
      .then(result => this.myBooks.splice(0, 1, result))
      .catch(error => console.error(error));
    }
    
    // watchers
  }

</script>

<style lang="scss">

</style>

<template>
  <div class="books-container">
    <h1>My books</h1>
    <div v-if="myBooks.length">
      <div v-for="books in myBooks">
        <div v-for="book in books" :key="book.id">
          {{ book.title }} - {{ book.author }}
        </div>
      </div>
    </div>
  </div>
</template>