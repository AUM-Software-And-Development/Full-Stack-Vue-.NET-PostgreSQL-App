<template>

    <div class="book-wrapper">
        {{ book.title }}
    </div>

</template>

<script lang="ts">
    import IBook from '@/types/Book';
    import {Options, Vue} from 'vue-class-component';

    @Options({
        props: {required: true},
        name: "Book",
        components: {}
    })
    export default class Book extends Vue{
        book!: IBook
    }
</script>

<style scoped lang="scss">

    .book-wrapper {
        margin: 0.81rem;
        padding: 0.48rem;
        border: 1px solid black;
        border-radius: 1rem;
    }

</style>